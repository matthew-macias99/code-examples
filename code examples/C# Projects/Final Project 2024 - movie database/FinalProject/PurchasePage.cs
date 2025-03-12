using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PurchasePage : Form
    {
        private Movie _movie;
        private SearchPage _searchPage;
        public PurchasePage(Movie movie, SearchPage searchPage)
        {
            InitializeComponent();
            _movie = movie;
            _searchPage = searchPage;
            pbPoster.ImageLocation = Path.Combine(Application.StartupPath, _movie.PosterPath);
            lblTitle.Text = _movie.Title;

            cmbQuantity.Items.Add("Select Quantity");
            cmbQuantity.Items.AddRange(new object[] { 1, 2, 3, 4, 5, });
            cmbQuantity.SelectedIndex = 0;

            cmbQuantity.SelectedIndexChanged += cmbQuantity_SelectedIndexChanged;
            cbxStandard.CheckedChanged += (s, e) => CalculateTotal();
            cbxBluRay.CheckedChanged += (s, e) => CalculateTotal();
            cbx4K.CheckedChanged += (s, e) => CalculateTotal();
        }
        //CALCULATE TOTAL
        private void CalculateTotal()
        {
            int total = 0;

            if (cbxStandard.Checked) total += 25;
            if (cbxBluRay.Checked) total += 30;
            if (cbx4K.Checked) total += 40;

            if (cmbQuantity.SelectedItem != null && cmbQuantity.SelectedItem.ToString() != "Select Quantity")
            {
                int quantity = int.Parse(cmbQuantity.SelectedItem.ToString());
                total *= quantity;
            }
            else
            {
                lblTotal.Visible = true;
                lblTotal.Text = "$0";
                return;
            }
            lblTotal.Visible = true;
            lblTotal.Text = $"{total:c}";
        }
        private void cbxStandard_CheckChanged(object sender, EventArgs e) => CalculateTotal();
        private void cbxBluRay_CheckChanged(object sender, EventArgs e) => CalculateTotal();
        private void cbx4K_CheckChanged(object sender, EventArgs e) => CalculateTotal();
        private void cmbQuantity_SelectedIndexChanged(object sender, EventArgs e) => CalculateTotal();

        //PURCHASE BUTTON
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (!cbxStandard.Checked && !cbxBluRay.Checked && !cbx4K.Checked)
            {
                MessageBox.Show("Please select at least one version to purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbQuantity.SelectedItem == null)
            {
                MessageBox.Show("Please select a quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Purchase completed! Thank you!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        //BACK BUTTON
        private void btnBack_Click(object sender, EventArgs e)
        {
            var moviePage = new MoviePage(_movie, _searchPage);
            moviePage.Show();
            this.Close();
        }
    }
}
