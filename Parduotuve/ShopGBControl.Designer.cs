
namespace Parduotuve
{
    partial class ShopGBControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddToCart = new System.Windows.Forms.Button();
            this.gb = new System.Windows.Forms.GroupBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.TruePriceLbl = new System.Windows.Forms.Label();
            this.TrueQtyLbl = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddToCart
            // 
            this.AddToCart.AutoSize = true;
            this.AddToCart.Location = new System.Drawing.Point(345, 18);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(96, 27);
            this.AddToCart.TabIndex = 0;
            this.AddToCart.Text = "Add To Cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.TrueQtyLbl);
            this.gb.Controls.Add(this.TruePriceLbl);
            this.gb.Controls.Add(this.QuantityLbl);
            this.gb.Controls.Add(this.PriceLbl);
            this.gb.Controls.Add(this.AddToCart);
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(460, 55);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(17, 23);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(44, 17);
            this.PriceLbl.TabIndex = 1;
            this.PriceLbl.Text = "Price:";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Location = new System.Drawing.Point(176, 23);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(65, 17);
            this.QuantityLbl.TabIndex = 2;
            this.QuantityLbl.Text = "Quantity:";
            // 
            // TruePriceLbl
            // 
            this.TruePriceLbl.AutoSize = true;
            this.TruePriceLbl.Location = new System.Drawing.Point(67, 23);
            this.TruePriceLbl.Name = "TruePriceLbl";
            this.TruePriceLbl.Size = new System.Drawing.Size(0, 17);
            this.TruePriceLbl.TabIndex = 3;
            // 
            // TrueQtyLbl
            // 
            this.TrueQtyLbl.AutoSize = true;
            this.TrueQtyLbl.Location = new System.Drawing.Point(247, 23);
            this.TrueQtyLbl.Name = "TrueQtyLbl";
            this.TrueQtyLbl.Size = new System.Drawing.Size(0, 17);
            this.TrueQtyLbl.TabIndex = 4;
            // 
            // ShopGBControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gb);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ShopGBControl";
            this.Size = new System.Drawing.Size(460, 55);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label TrueQtyLbl;
        private System.Windows.Forms.Label TruePriceLbl;
        private System.Windows.Forms.Label QuantityLbl;
    }
}
