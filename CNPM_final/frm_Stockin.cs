using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frm_Stockin : Form
    {
        private DataTable productTable = new DataTable();
        private string selectedProductID = string.Empty;
        private string selectedImagePath = string.Empty;

        public frm_Stockin()
        {
            InitializeComponent();
        }

        private void frm_Stockin_Load(object sender, EventArgs e)
        {
            // Kiểm tra các điều khiển có tồn tại không
            if (txtPName == null || txtPBrand == null || txtPPrice == null || txtPStock == null ||
                cbSport == null || cbColor == null || image == null || grd == null)
            {
                MessageBox.Show("One or more controls are not initialized. Please check the form design.");
                return;
            }

            // Khởi tạo danh sách môn thể thao và màu sắc
            cbSport.Items.AddRange(new string[] { "Football", "Basketball", "Martial Arts", "Badminton", "Tennis", "Golf", "Swimming", "Gym & Fitness", "Running" });
            cbColor.Items.AddRange(new string[] { "Red", "Blue", "Green", "Black", "White" });

            // Tải dữ liệu sản phẩm
            LoadProductData();
            SetupGrd();

            // Đăng ký sự kiện cho các nút
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnImport.Click += btnImport_Click;

            // Đăng ký sự kiện click cho DataGridView
            grd.CellClick += grd_CellClick;
        }

        private void LoadProductData()
        {
            try
            {
                productTable = BUS_Products.GetAllProducts();
                if (productTable == null)
                {
                    productTable = new DataTable();
                }
                grd.DataSource = productTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product data: {ex.Message}");
            }
        }

        private void SetupGrd()
        {
            grd.Columns.Clear();
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "ProductID", HeaderText = "Product ID", DataPropertyName = "product_id" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "PName", HeaderText = "Product Name", DataPropertyName = "p_name" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "Brand", HeaderText = "Brand", DataPropertyName = "brand" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "Color", HeaderText = "Color", DataPropertyName = "color" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "Type", HeaderText = "Type", DataPropertyName = "type" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Price", DataPropertyName = "price" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "StockQuantity", HeaderText = "Stock", DataPropertyName = "stock_quantity" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "ImagePath", HeaderText = "Image Path", DataPropertyName = "image_path" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "CreatedAt", HeaderText = "Created At", DataPropertyName = "created_at" });
            grd.Columns.Add(new DataGridViewTextBoxColumn { Name = "UpdatedAt", HeaderText = "Updated At", DataPropertyName = "updated_at" });

            grd.AutoGenerateColumns = false;
            grd.DataSource = productTable;
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grd.Rows[e.RowIndex];

                selectedProductID = row.Cells["ProductID"].Value?.ToString() ?? string.Empty;
                txtPName.Text = row.Cells["PName"].Value?.ToString() ?? string.Empty;
                txtPBrand.Text = row.Cells["Brand"].Value?.ToString() ?? string.Empty;
                cbColor.Text = row.Cells["Color"].Value?.ToString() ?? string.Empty;
                cbSport.Text = row.Cells["Type"].Value?.ToString() ?? string.Empty;
                txtPPrice.Text = row.Cells["Price"].Value?.ToString() ?? string.Empty;
                txtPStock.Text = row.Cells["StockQuantity"].Value?.ToString() ?? string.Empty;
                selectedImagePath = row.Cells["ImagePath"].Value?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(selectedImagePath) && System.IO.File.Exists(selectedImagePath))
                {
                    try
                    {
                        image.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                        image.Image = null;
                    }
                }
                else
                {
                    image.Image = null;
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                try
                {
                    image.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                    selectedImagePath = string.Empty;
                    image.Image = null;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            decimal price = decimal.Parse(txtPPrice.Text);
            int stock = int.Parse(txtPStock.Text);

            string productID = GenerateProductID();
            DTO_Products product = new DTO_Products
            {
                ProductID = productID,
                PName = txtPName.Text.Trim(),
                Brand = txtPBrand.Text.Trim(),
                Color = cbColor.SelectedItem.ToString(),
                Type = cbSport.SelectedItem.ToString(),
                Price = price,
                StockQuantity = stock,
                ImagePath = selectedImagePath
                // CreatedAt and UpdatedAt are handled by SQL defaults
            };

            try
            {
                BUS_Products busProduct = new BUS_Products(product);
                busProduct.addQuery();
                LoadProductData();
                MessageBox.Show("Product added successfully.");
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedProductID))
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            decimal price = decimal.Parse(txtPPrice.Text);
            int stock = int.Parse(txtPStock.Text);

            DTO_Products product = new DTO_Products
            {
                ProductID = selectedProductID,
                PName = txtPName.Text.Trim(),
                Brand = txtPBrand.Text.Trim(),
                Color = cbColor.SelectedItem.ToString(),
                Type = cbSport.SelectedItem.ToString(),
                Price = price,
                StockQuantity = stock,
                ImagePath = selectedImagePath
                // CreatedAt and UpdatedAt are handled by SQL defaults
            };

            try
            {
                BUS_Products busProduct = new BUS_Products(product);
                busProduct.updateQuery();
                LoadProductData();
                MessageBox.Show("Product updated successfully.");
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedProductID))
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DTO_Products product = new DTO_Products { ProductID = selectedProductID };
                    BUS_Products busProduct = new BUS_Products(product);
                    busProduct.deleteQuery();
                    LoadProductData();
                    MessageBox.Show("Product deleted successfully.");
                    btnClear_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting product: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedProductID = string.Empty;
            selectedImagePath = string.Empty;
            txtPName.Text = string.Empty;
            txtPBrand.Text = string.Empty;
            cbSport.SelectedIndex = -1;
            cbColor.SelectedIndex = -1;
            txtPPrice.Text = string.Empty;
            txtPStock.Text = string.Empty;
            image.Image = null;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtPName.Text) || string.IsNullOrWhiteSpace(txtPBrand.Text) ||
                cbSport.SelectedItem == null || cbColor.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtPPrice.Text) || string.IsNullOrWhiteSpace(txtPStock.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return false;
            }

            if (!decimal.TryParse(txtPPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Price must be a valid non-negative number.");
                return false;
            }

            if (!int.TryParse(txtPStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Stock must be a valid non-negative integer.");
                return false;
            }

            return true;
        }

        private string GenerateProductID()
        {
            string prefix = "p";
            string today = DateTime.Now.ToString("yyyyMMdd");

            string sportPrefix = cbSport.SelectedItem.ToString() switch
            {
                "Basketball" => "BAS",
                "Martial Arts" => "MA",
                "Badminton" => "BMT",
                "Tennis" => "TN",
                "Golf" => "GF",
                "Swimming" => "SWM",
                "Gym & Fitness" => "GyF",
                "Running" => "RUN",
                _ => "UNK"
            };

            int count = productTable.AsEnumerable()
                .Where(r => r.Field<string>("product_id")?.StartsWith($"{prefix}{today}{sportPrefix}") ?? false)
                .Count();

            int nextNumber = count + 1;
            string formattedNumber = nextNumber.ToString("D4");

            return $"{prefix}{today}{sportPrefix}{formattedNumber}";
        }
    }
}