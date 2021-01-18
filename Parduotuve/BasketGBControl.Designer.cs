
namespace Parduotuve
{
    partial class BasketGBControl
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.TrueQtyLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.TruePriceLbl = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.TruePriceLbl);
            this.gb.Controls.Add(this.PriceLbl);
            this.gb.Controls.Add(this.TrueQtyLbl);
            this.gb.Controls.Add(this.QuantityLbl);
            this.gb.Controls.Add(this.MinusBtn);
            this.gb.Controls.Add(this.PlusBtn);
            this.gb.Location = new System.Drawing.Point(3, 3);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(410, 53);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            // 
            // PlusBtn
            // 
            this.PlusBtn.AutoSize = true;
            this.PlusBtn.Location = new System.Drawing.Point(376, 18);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(26, 27);
            this.PlusBtn.TabIndex = 0;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            // 
            // MinusBtn
            // 
            this.MinusBtn.AutoSize = true;
            this.MinusBtn.Location = new System.Drawing.Point(220, 17);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(26, 27);
            this.MinusBtn.TabIndex = 1;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Location = new System.Drawing.Point(261, 22);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(65, 17);
            this.QuantityLbl.TabIndex = 2;
            this.QuantityLbl.Text = "Quantity:";
            // 
            // TrueQtyLbl
            // 
            this.TrueQtyLbl.AutoSize = true;
            this.TrueQtyLbl.Location = new System.Drawing.Point(333, 22);
            this.TrueQtyLbl.Name = "TrueQtyLbl";
            this.TrueQtyLbl.Size = new System.Drawing.Size(24, 17);
            this.TrueQtyLbl.TabIndex = 3;
            this.TrueQtyLbl.Text = "19";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(18, 22);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(44, 17);
            this.PriceLbl.TabIndex = 4;
            this.PriceLbl.Text = "Price:";
            // 
            // TruePriceLbl
            // 
            this.TruePriceLbl.AutoSize = true;
            this.TruePriceLbl.Location = new System.Drawing.Point(69, 22);
            this.TruePriceLbl.Name = "TruePriceLbl";
            this.TruePriceLbl.Size = new System.Drawing.Size(0, 17);
            this.TruePriceLbl.TabIndex = 5;
            // 
            // BasketGBControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gb);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BasketGBControl";
            this.Size = new System.Drawing.Size(416, 59);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label TruePriceLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label TrueQtyLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button PlusBtn;
    }
}
