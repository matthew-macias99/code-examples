namespace FinalProject
{
    partial class PurchasePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            lblTitle = new Label();
            pbPoster = new PictureBox();
            lblSelectVersion = new Label();
            cbxStandard = new CheckBox();
            cbxBluRay = new CheckBox();
            cbx4K = new CheckBox();
            lblQuantity = new Label();
            cmbQuantity = new ComboBox();
            lblTotalText = new Label();
            lblTotal = new Label();
            btnPurchase = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPoster).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(255, 185, 120);
            lblTitle.Location = new Point(47, 72);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(78, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "title";
            // 
            // pbPoster
            // 
            pbPoster.Location = new Point(47, 132);
            pbPoster.Name = "pbPoster";
            pbPoster.Size = new Size(350, 530);
            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPoster.TabIndex = 1;
            pbPoster.TabStop = false;
            // 
            // lblSelectVersion
            // 
            lblSelectVersion.AutoSize = true;
            lblSelectVersion.Font = new Font("Cambria", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectVersion.ForeColor = Color.FromArgb(255, 74, 67);
            lblSelectVersion.Location = new Point(550, 132);
            lblSelectVersion.Name = "lblSelectVersion";
            lblSelectVersion.Size = new Size(210, 37);
            lblSelectVersion.TabIndex = 2;
            lblSelectVersion.Text = "Select Version";
            // 
            // cbxStandard
            // 
            cbxStandard.AutoSize = true;
            cbxStandard.Font = new Font("Cambria", 18F);
            cbxStandard.ForeColor = Color.FromArgb(255, 185, 120);
            cbxStandard.Location = new Point(550, 174);
            cbxStandard.Name = "cbxStandard";
            cbxStandard.Size = new Size(185, 32);
            cbxStandard.TabIndex = 3;
            cbxStandard.Text = "Standard ($25)";
            cbxStandard.UseVisualStyleBackColor = true;
            // 
            // cbxBluRay
            // 
            cbxBluRay.AutoSize = true;
            cbxBluRay.Font = new Font("Cambria", 18F);
            cbxBluRay.ForeColor = Color.FromArgb(255, 185, 120);
            cbxBluRay.Location = new Point(550, 216);
            cbxBluRay.Name = "cbxBluRay";
            cbxBluRay.Size = new Size(174, 32);
            cbxBluRay.TabIndex = 4;
            cbxBluRay.Text = "Blu-Ray ($30)";
            cbxBluRay.UseVisualStyleBackColor = true;
            // 
            // cbx4K
            // 
            cbx4K.AutoSize = true;
            cbx4K.Font = new Font("Cambria", 18F);
            cbx4K.ForeColor = Color.FromArgb(255, 185, 120);
            cbx4K.Location = new Point(550, 258);
            cbx4K.Name = "cbx4K";
            cbx4K.Size = new Size(173, 32);
            cbx4K.TabIndex = 5;
            cbx4K.Text = "4K UHD ($40)";
            cbx4K.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Cambria", 24F);
            lblQuantity.ForeColor = Color.FromArgb(255, 74, 67);
            lblQuantity.Location = new Point(550, 323);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(145, 37);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity:";
            // 
            // cmbQuantity
            // 
            cmbQuantity.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbQuantity.FormattingEnabled = true;
            cmbQuantity.Location = new Point(550, 362);
            cmbQuantity.Name = "cmbQuantity";
            cmbQuantity.Size = new Size(121, 22);
            cmbQuantity.TabIndex = 7;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Cambria", 24F);
            lblTotalText.ForeColor = Color.FromArgb(255, 74, 67);
            lblTotalText.Location = new Point(550, 438);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(94, 37);
            lblTotalText.TabIndex = 8;
            lblTotalText.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(255, 185, 120);
            lblTotal.Location = new Point(550, 474);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(153, 37);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "total cost";
            lblTotal.Visible = false;
            // 
            // btnPurchase
            // 
            btnPurchase.Font = new Font("Cambria", 9F);
            btnPurchase.ForeColor = Color.FromArgb(33, 26, 25);
            btnPurchase.Location = new Point(550, 539);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(75, 23);
            btnPurchase.TabIndex = 10;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Cambria", 9F);
            btnBack.ForeColor = Color.FromArgb(33, 26, 25);
            btnBack.Location = new Point(901, 702);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PurchasePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 26, 25);
            ClientSize = new Size(988, 737);
            Controls.Add(btnBack);
            Controls.Add(btnPurchase);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalText);
            Controls.Add(cmbQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cbx4K);
            Controls.Add(cbxBluRay);
            Controls.Add(cbxStandard);
            Controls.Add(lblSelectVersion);
            Controls.Add(pbPoster);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PurchasePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)pbPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pbPoster;
        private Label lblSelectVersion;
        private CheckBox cbxStandard;
        private CheckBox cbxBluRay;
        private CheckBox cbx4K;
        private Label lblQuantity;
        private ComboBox cmbQuantity;
        private Label lblTotalText;
        private Label lblTotal;
        private Button btnPurchase;
        private Button btnBack;
    }
}