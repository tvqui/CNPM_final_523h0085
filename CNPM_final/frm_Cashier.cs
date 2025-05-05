using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using BUS;
using DAL;
using DTO;

namespace GUI
{
    public partial class frm_Cashier : Form
    {
        private string _username;
        private DataTable productTable = new DataTable();
        private DataTable orderTable = new DataTable();

        public frm_Cashier(string username)
        {
            InitializeComponent();
            this._username = username;
        }

        public frm_Cashier()
        {
            InitializeComponent();
        }

        private void frm_Cashier_Load_1(object sender, EventArgs e)
        {
            try
            {
                productTable = GetProductData();
                orderTable.Columns.Add("Name", typeof(string));
                orderTable.Columns.Add("Color", typeof(string));
                orderTable.Columns.Add("Quantity", typeof(int));
                List.DataSource = orderTable;

                LoadFilterCombos();
                SetupGrd();
                SetupList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetProductData()
        {
            return BUS_Products.GetAllProducts();
        }

        private void LoadFilterCombos()
        {
            cbSport.Items.Clear();
            cbName.Items.Clear();
            cbBrand.Items.Clear();
            cbColor.Items.Clear();
            cbPrice.Items.Clear();

            cbSport.Items.Add("All");
            cbName.Items.Add("All");
            cbBrand.Items.Add("All");
            cbColor.Items.Add("All");
            cbPrice.Items.Add("All");

            var sports = productTable.AsEnumerable()
                .Select(r => r.Field<string>("type"))
                .Distinct()
                .OrderBy(x => x);
            foreach (var s in sports)
                cbSport.Items.Add(s);

            var names = productTable.AsEnumerable()
                .Select(r => r.Field<string>("p_name"))
                .Distinct()
                .OrderBy(x => x);
            foreach (var n in names)
                cbName.Items.Add(n);

            var brands = productTable.AsEnumerable()
                .Select(r => r.Field<string>("brand"))
                .Distinct()
                .OrderBy(x => x);
            foreach (var b in brands)
                cbBrand.Items.Add(b);

            var colors = productTable.AsEnumerable()
                .Select(r => r.Field<string>("color"))
                .Distinct()
                .OrderBy(x => x);
            foreach (var c in colors)
                cbColor.Items.Add(c);

            var prices = productTable.AsEnumerable()
                .Select(r => r.Field<decimal>("Price").ToString())
                .Distinct()
                .OrderBy(x => decimal.Parse(x));
            foreach (var p in prices)
                cbPrice.Items.Add(p);

            cbSport.SelectedIndex = 0;
            cbName.SelectedIndex = 0;
            cbBrand.SelectedIndex = 0;
            cbColor.SelectedIndex = 0;
            cbPrice.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            try
            {
                string sportFilter = cbSport.SelectedItem?.ToString() == "All" ? "" : cbSport.SelectedItem?.ToString();
                string nameFilter = cbName.SelectedItem?.ToString() == "All" ? "" : cbName.SelectedItem?.ToString();
                string brandFilter = cbBrand.SelectedItem?.ToString() == "All" ? "" : cbBrand.SelectedItem?.ToString();
                string colorFilter = cbColor.SelectedItem?.ToString() == "All" ? "" : cbColor.SelectedItem?.ToString();
                string priceFilter = cbPrice.SelectedItem?.ToString() == "All" ? "" : cbPrice.SelectedItem?.ToString();

                var filteredRows = productTable.AsEnumerable().Where(row =>
                    (string.IsNullOrEmpty(sportFilter) || row.Field<string>("type") == sportFilter) &&
                    (string.IsNullOrEmpty(nameFilter) || row.Field<string>("p_name").ToLower().Contains(nameFilter.ToLower())) &&
                    (string.IsNullOrEmpty(brandFilter) || row.Field<string>("brand") == brandFilter) &&
                    (string.IsNullOrEmpty(colorFilter) || row.Field<string>("color") == colorFilter) &&
                    (string.IsNullOrEmpty(priceFilter) || row.Field<decimal>("Price").ToString() == priceFilter)
                );

                grd.Rows.Clear();
                if (filteredRows.Any())
                {
                    foreach (DataRow dataRow in filteredRows)
                    {
                        int rowIndex = grd.Rows.Add();
                        grd.Rows[rowIndex].Cells["IDP"].Value = dataRow["product_id"];
                        string imagePath = dataRow["image_path"].ToString();
                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            try
                            {
                                if (System.IO.File.Exists(imagePath))
                                    grd.Rows[rowIndex].Cells["PictureP"].Value = Image.FromFile(imagePath);
                                else
                                    MessageBox.Show($"Image not found: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error loading image {imagePath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        grd.Rows[rowIndex].Cells["NameP"].Value = dataRow["p_name"];
                        grd.Rows[rowIndex].Cells["BrandP"].Value = dataRow["brand"];
                        grd.Rows[rowIndex].Cells["ColorP"].Value = dataRow["color"];
                        grd.Rows[rowIndex].Cells["PriceP"].Value = dataRow["price"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (orderTable.Rows.Count == 0)
            {
                MessageBox.Show("No products selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                foreach (DataRow row in orderTable.Rows)
                {
                    string name = row["Name"].ToString();
                    string color = row["Color"].ToString();
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    SaveOrder(name, color, quantity);
                }
                MessageBox.Show("Payment successful.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form in hóa đơn
                using (frm_Print printForm = new frm_Print(orderTable.Copy(), productTable.Copy(), _username))
                {
                    printForm.ShowDialog();
                }

                orderTable.Clear();
                SetupList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Payment error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveOrder(string name, string color, int quantity)
        {
            DataRow product = productTable.AsEnumerable().FirstOrDefault(r =>
                r.Field<string>("p_name") == name && r.Field<string>("color") == color);

            if (product == null)
            {
                MessageBox.Show($"Product not found: {name} ({color})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string productId = product["product_id"].ToString();
            string brand = product["brand"].ToString();
            string imagePath = product["image_path"].ToString();
            decimal unitPrice = Convert.ToDecimal(product["Price"]);
            string orderId = Guid.NewGuid().ToString();
            DateTime orderDate = DateTime.Now;

            DTO_Orders order = new DTO_Orders
            {
                OrderID = orderId,
                Username = _username,
                OrderDate = orderDate,
                ProductID = productId,
                PName = name,
                Brand = brand,
                Color = color,
                Quantity = quantity,
                UnitPrice = unitPrice,
                ImagePath = imagePath,
                PStatus = "Bought"
            };

            BUS_Orders.InsertOrder(order);
        }

        private void SetupGrd()
        {
            grd.Columns.Clear();
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "IDP", HeaderText = "#" });
            grd.Columns.Add(new DataGridViewImageColumn { Name = "PictureP", HeaderText = "Image" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "NameP", HeaderText = "Product Name" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "BrandP", HeaderText = "Brand" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColorP", HeaderText = "Color" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "PriceP", HeaderText = "Price" });
            grd.Columns.Add(new DataGridViewButtonColumn { Name = "AddP", HeaderText = "Add", Text = "Add", UseColumnTextForButtonValue = true });
            grd.Columns.Add(new DataGridViewButtonColumn { Name = "DeleteP", HeaderText = "Remove", Text = "Remove", UseColumnTextForButtonValue = true });

            grd.Rows.Clear();
            if (productTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in productTable.Rows)
                {
                    int rowIndex = grd.Rows.Add();
                    grd.Rows[rowIndex].Cells["IDP"].Value = dataRow["product_id"];
                    string imagePath = dataRow["image_path"].ToString();
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        try
                        {
                            if (System.IO.File.Exists(imagePath))
                                grd.Rows[rowIndex].Cells["PictureP"].Value = Image.FromFile(imagePath);
                            else
                                MessageBox.Show($"Image not found: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image {imagePath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    grd.Rows[rowIndex].Cells["NameP"].Value = dataRow["p_name"];
                    grd.Rows[rowIndex].Cells["BrandP"].Value = dataRow["brand"];
                    grd.Rows[rowIndex].Cells["ColorP"].Value = dataRow["color"];
                    grd.Rows[rowIndex].Cells["PriceP"].Value = dataRow["price"];
                }
            }
        }

        private void SetupList()
        {
            List.Columns.Clear();
            List.Columns.Add(new DataGridViewTextBoxColumn { Name = "NamePList", HeaderText = "Product Name" });
            List.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColorPList", HeaderText = "Color" });
            List.Columns.Add(new DataGridViewButtonColumn { Name = "AddPList", HeaderText = "Add", Text = "Add", UseColumnTextForButtonValue = true });
            List.Columns.Add(new DataGridViewTextBoxColumn { Name = "QuantityPList", HeaderText = "Quantity" });
            List.Columns.Add(new DataGridViewButtonColumn { Name = "DeletePList", HeaderText = "Remove", Text = "Remove", UseColumnTextForButtonValue = true });

            List.DataSource = null;

            foreach (DataRow dataRow in orderTable.Rows)
            {
                int rowIndex = List.Rows.Add();
                List.Rows[rowIndex].Cells["NamePList"].Value = dataRow["Name"];
                List.Rows[rowIndex].Cells["ColorPList"].Value = dataRow["Color"];
                List.Rows[rowIndex].Cells["QuantityPList"].Value = dataRow["Quantity"];
            }
        }

        private void grd_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string productId = grd.Rows[e.RowIndex].Cells["IDP"].Value.ToString();
            string name = grd.Rows[e.RowIndex].Cells["NameP"].Value.ToString();
            string color = grd.Rows[e.RowIndex].Cells["ColorP"].Value.ToString();

            if (e.ColumnIndex == grd.Columns["AddP"].Index)
            {
                DataRow existing = orderTable.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("Name") == name && r.Field<string>("Color") == color);

                if (existing != null)
                    existing["Quantity"] = Convert.ToInt32(existing["Quantity"]) + 1;
                else
                    orderTable.Rows.Add(name, color, 1);
                SetupList();
            }
            else if (e.ColumnIndex == grd.Columns["DeleteP"].Index)
            {
                DataRow existing = orderTable.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("Name") == name && r.Field<string>("Color") == color);
                if (existing != null)
                {
                    int quantity = Convert.ToInt32(existing["Quantity"]);
                    if (quantity <= 1)
                        orderTable.Rows.Remove(existing);
                    else
                        existing["Quantity"] = quantity - 1;
                    SetupList();
                }
            }
        }

        private void List_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string name = List.Rows[e.RowIndex].Cells["NamePList"].Value.ToString();
            string color = List.Rows[e.RowIndex].Cells["ColorPList"].Value.ToString();
            DataRow row = orderTable.AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("Name") == name && r.Field<string>("Color") == color);

            if (row == null) return;

            if (e.ColumnIndex == List.Columns["AddPList"].Index)
            {
                row["Quantity"] = Convert.ToInt32(row["Quantity"]) + 1;
            }
            else if (e.ColumnIndex == List.Columns["DeletePList"].Index)
            {
                int quantity = Convert.ToInt32(row["Quantity"]);
                if (quantity <= 1)
                    orderTable.Rows.Remove(row);
                else
                    row["Quantity"] = quantity - 1;
            }
            SetupList();
        }

        private void cbSport_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cbName_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cbColor_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cbPrice_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
    }
}