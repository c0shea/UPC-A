using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UPCA {
    public partial class UPCA : Form {
        public UPCA() {
            InitializeComponent();
        }

        private void txtTextToAdd_TextChanged(object sender, EventArgs e) {
            txtUPC.Text = Regex.Replace(txtUPC.Text, @"\D", "");
            GenerateUpc();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e) {
            txtPrice.Text = Regex.Replace(txtPrice.Text, @"\D", "");
            GenerateUpc();
        }

        private void GenerateUpc() {
            var upca = new Barcode();
            if (txtUPC.Text.Length == 6 && txtPrice.Text.Length == 4) {
                var upc = txtUPC.Text + RandomWeightCheckDigit(txtPrice.Text) + txtPrice.Text;
                upc += upca.GetCheckSum(upc);
                var img = upca.CreateBarCode(upc, 4);
                pctBarCode.Left = Convert.ToInt32(pnlWhiteBack.Width / 2 - img.Width / 2);
                pctBarCode.Image = img;
            }
            else {
                pctBarCode.Image = null;
            }
        }

        private char RandomWeightCheckDigit(string price) {
            int[] firstSecond = { 0, 2, 4, 6, 8, 9, 1, 3, 5, 7 };
            int[] third = { 0, 3, 6, 9, 2, 5, 8, 1, 4, 7 };
            int[] fourth = { 0, 5, 9, 4, 8, 3, 7, 2, 6, 1 };

            var retval = "" + (firstSecond[Convert.ToInt32(price.Substring(0, 1))] + firstSecond[Convert.ToInt32(price.Substring(1, 1))] + third[Convert.ToInt32(price.Substring(2, 1))] + fourth[Convert.ToInt32(price.Substring(3, 1))]) * 3;

            return retval.Substring(retval.Length - 1)[0];
        }

        private void btnCalculateRetailPrice_Click(object sender, EventArgs e) {
            if (Height < 765) {
                for (var i = 0; i < 63; i++) {
                    // Height will go from 644 to 770
                    Height += 2;
                }

                txtPricePerLb.Focus();
            }
        }

        private void txtPricePerLb_TextChanged(object sender, EventArgs e) {
            txtPricePerLb.Text = Regex.Replace(txtPricePerLb.Text, @"\D", "");
            CalculatePrice();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e) {
            txtWeight.Text = Regex.Replace(txtWeight.Text, @"\D", "");
            CalculatePrice();
        }

        private void CalculatePrice() {
            if (txtPricePerLb.Text.Length > 0 && txtWeight.Text.Length > 0) {
                var pricePerLb = Convert.ToDouble(txtPricePerLb.Text);
                var weight = Convert.ToDouble(txtWeight.Text);

                pricePerLb /= 100;
                weight /= 100;

                txtPrice.Text = "" + ((int)(pricePerLb * weight * 100)).ToString("0000");
            }
        }
    }
}