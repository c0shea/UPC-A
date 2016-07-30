using System.ComponentModel;
using System.Windows.Forms;

namespace UPCA
{
  partial class UPCA
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if(disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UPCA));
            this.pctBarCode = new System.Windows.Forms.PictureBox();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.pnlWhiteBack = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculateRetailPrice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPricePerLb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarCode)).BeginInit();
            this.pnlWhiteBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctBarCode
            // 
            this.pctBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBarCode.BackColor = System.Drawing.Color.White;
            this.pctBarCode.Location = new System.Drawing.Point(15, 20);
            this.pctBarCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pctBarCode.Name = "pctBarCode";
            this.pctBarCode.Size = new System.Drawing.Size(476, 321);
            this.pctBarCode.TabIndex = 0;
            this.pctBarCode.TabStop = false;
            // 
            // txtUPC
            // 
            this.txtUPC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUPC.Location = new System.Drawing.Point(274, 458);
            this.txtUPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUPC.MaxLength = 6;
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(153, 39);
            this.txtUPC.TabIndex = 0;
            this.txtUPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUPC.TextChanged += new System.EventHandler(this.txtTextToAdd_TextChanged);
            // 
            // pnlWhiteBack
            // 
            this.pnlWhiteBack.BackColor = System.Drawing.Color.White;
            this.pnlWhiteBack.Controls.Add(this.pctBarCode);
            this.pnlWhiteBack.Location = new System.Drawing.Point(28, 76);
            this.pnlWhiteBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlWhiteBack.Name = "pnlWhiteBack";
            this.pnlWhiteBack.Size = new System.Drawing.Size(505, 361);
            this.pnlWhiteBack.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(274, 510);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.MaxLength = 4;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(153, 39);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ex: 0598";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter the First 6 Digits of the UPC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter the 4-Digit Price in Cents:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(562, 56);
            this.label5.TabIndex = 15;
            this.label5.Text = "UPC-A Random Weight Barcode Generator";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculateRetailPrice
            // 
            this.btnCalculateRetailPrice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculateRetailPrice.FlatAppearance.BorderSize = 0;
            this.btnCalculateRetailPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateRetailPrice.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateRetailPrice.ForeColor = System.Drawing.Color.White;
            this.btnCalculateRetailPrice.Location = new System.Drawing.Point(274, 563);
            this.btnCalculateRetailPrice.Name = "btnCalculateRetailPrice";
            this.btnCalculateRetailPrice.Size = new System.Drawing.Size(234, 29);
            this.btnCalculateRetailPrice.TabIndex = 2;
            this.btnCalculateRetailPrice.Text = "Calculate Retail Price By Weight";
            this.btnCalculateRetailPrice.UseVisualStyleBackColor = false;
            this.btnCalculateRetailPrice.Click += new System.EventHandler(this.btnCalculateRetailPrice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Enter the Regular Price Per Pound:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 621);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ex: 1298";
            // 
            // txtPricePerLb
            // 
            this.txtPricePerLb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerLb.Location = new System.Drawing.Point(274, 608);
            this.txtPricePerLb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPricePerLb.MaxLength = 4;
            this.txtPricePerLb.Name = "txtPricePerLb";
            this.txtPricePerLb.Size = new System.Drawing.Size(153, 39);
            this.txtPricePerLb.TabIndex = 3;
            this.txtPricePerLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPricePerLb.TextChanged += new System.EventHandler(this.txtPricePerLb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 673);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Enter the Weight:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(440, 673);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ex: 0598";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(274, 660);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.MaxLength = 4;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(153, 39);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkRed;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-6, 714);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(568, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Due to scale rounding, the calculated price by weight may vary from the label ret" +
    "ail price.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 606);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPricePerLb);
            this.Controls.Add(this.btnCalculateRetailPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtUPC);
            this.Controls.Add(this.pnlWhiteBack);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UPCA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPC-A Random Weight Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pctBarCode)).EndInit();
            this.pnlWhiteBack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    internal PictureBox pctBarCode;
    internal TextBox txtUPC;
    internal Panel pnlWhiteBack;
    internal TextBox txtPrice;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Button btnCalculateRetailPrice;
    private Label label7;
    private Label label8;
    internal TextBox txtPricePerLb;
    private Label label9;
    private Label label10;
    internal TextBox txtWeight;
    private Label label11;
  }
}

