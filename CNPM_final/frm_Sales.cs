using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;

namespace GUI
{
    public partial class frm_Sales : Form
    {
        private DataTable orderHistoryTable = new DataTable(); // Order history data
        private DataTable filteredTable = new DataTable(); // Data after filtering

        public frm_Sales()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frm_Sales_Load(object sender, EventArgs e)
        {
            // Load all purchased order data
            try
            {
                orderHistoryTable = BUS_Orders.GetAllPurchasedOrders();
                filteredTable = orderHistoryTable.Copy(); // Copy original data
                SetupGrd();
                SetupComboBoxes();
                CalculateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupGrd()
        {
            // Configure DataGridView
            grd.DataSource = filteredTable;

            // Set column headers
            grd.Columns["OrderID"].HeaderText = "Order ID";
            grd.Columns["Username"].HeaderText = "Username";
            grd.Columns["OrderDate"].HeaderText = "Order Date";
            grd.Columns["ProductID"].HeaderText = "Product ID";
            grd.Columns["PName"].HeaderText = "Product Name";
            grd.Columns["Brand"].HeaderText = "Brand";
            grd.Columns["Color"].HeaderText = "Color";
            grd.Columns["Quantity"].HeaderText = "Quantity";
            grd.Columns["UnitPrice"].HeaderText = "Unit Price";
            grd.Columns["ImagePath"].HeaderText = "Image Path";
            grd.Columns["PStatus"].HeaderText = "Status";

            // Format date column
            grd.Columns["OrderDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            // Format price column
            grd.Columns["UnitPrice"].DefaultCellStyle.Format = "N0"; // No decimal, thousand separator

            // Align and size columns
            grd.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grd.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable editing
            grd.ReadOnly = true;
            grd.AllowUserToAddRows = false;
        }

        private void SetupComboBoxes()
        {
            // Add "All" to each ComboBox
            cbSport.Items.Add("All");
            cbName.Items.Add("All");
            cbBrand.Items.Add("All");
            cbPrice.Items.Add("All");
            cbColor.Items.Add("All");

            // Extract unique values from orderHistoryTable
            var sports = orderHistoryTable.AsEnumerable()
                .Select(row => row.Field<string>("PName").Split('-')[0].Trim()) // Assume PName format: "Sport - Name"
                .Distinct()
                .OrderBy(s => s)
                .ToList();
            var names = orderHistoryTable.AsEnumerable()
                .Select(row => row.Field<string>("PName"))
                .Distinct()
                .OrderBy(n => n)
                .ToList();
            var brands = orderHistoryTable.AsEnumerable()
                .Select(row => row.Field<string>("Brand"))
                .Distinct()
                .OrderBy(b => b)
                .ToList();
            var colors = orderHistoryTable.AsEnumerable()
                .Select(row => row.Field<string>("Color"))
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            // Fill ComboBoxes
            cbSport.Items.AddRange(sports.ToArray());
            cbName.Items.AddRange(names.ToArray());
            cbBrand.Items.AddRange(brands.ToArray());
            cbColor.Items.AddRange(colors.ToArray());

            // Add fixed price ranges (can be customized)
            cbPrice.Items.AddRange(new string[] { "< 100,000", "100,000 - 500,000", "500,000 - 1,000,000", "> 1,000,000" });

            // Default selection to "All"
            cbSport.SelectedIndex = 0;
            cbName.SelectedIndex = 0;
            cbBrand.SelectedIndex = 0;
            cbPrice.SelectedIndex = 0;
            cbColor.SelectedIndex = 0;

            // Assign SelectedIndexChanged events
            cbSport.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbName.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbBrand.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbPrice.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbColor.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
            CalculateTotalAmount();
        }

        private void ApplyFilters()
        {
            // Copy original table
            filteredTable = orderHistoryTable.Copy();
            DataView dv = filteredTable.DefaultView;

            // Build filter expression
            List<string> filters = new List<string>();

            // Filter by sport (assume PName format is "Sport - Name")
            if (cbSport.SelectedItem?.ToString() != "All")
            {
                string sport = cbSport.SelectedItem.ToString();
                filters.Add($"PName LIKE '{sport}%'");
            }

            // Filter by product name
            if (cbName.SelectedItem?.ToString() != "All")
            {
                string name = cbName.SelectedItem.ToString();
                filters.Add($"PName = '{name}'");
            }

            // Filter by brand
            if (cbBrand.SelectedItem?.ToString() != "All")
            {
                string brand = cbBrand.SelectedItem.ToString();
                filters.Add($"Brand = '{brand}'");
            }

            // Filter by color
            if (cbColor.SelectedItem?.ToString() != "All")
            {
                string color = cbColor.SelectedItem.ToString();
                filters.Add($"Color = '{color}'");
            }

            // Filter by price range
            if (cbPrice.SelectedItem?.ToString() != "All")
            {
                string priceRange = cbPrice.SelectedItem.ToString();
                switch (priceRange)
                {
                    case "< 100,000":
                        filters.Add("UnitPrice < 100000");
                        break;
                    case "100,000 - 500,000":
                        filters.Add("UnitPrice >= 100000 AND UnitPrice <= 500000");
                        break;
                    case "500,000 - 1,000,000":
                        filters.Add("UnitPrice > 500000 AND UnitPrice <= 1000000");
                        break;
                    case "> 1,000,000":
                        filters.Add("UnitPrice > 1000000");
                        break;
                }
            }

            // Apply filter
            dv.RowFilter = filters.Count > 0 ? string.Join(" AND ", filters) : "";

            // Update DataGridView
            grd.DataSource = dv.ToTable();
        }

        private void CalculateTotalAmount()
        {
            // Calculate total amount = sum(UnitPrice * Quantity) from filteredTable
            decimal totalAmount = filteredTable.AsEnumerable()
                .Sum(row => row.Field<decimal>("UnitPrice") * row.Field<int>("Quantity"));

            // Display total amount in txtAmount, formatted in VND
            txtAmount.Text = totalAmount.ToString("N0") + " VND";
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Add logic to handle row clicks (e.g. show order details)
        }
    }
}
