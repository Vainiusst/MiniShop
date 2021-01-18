
namespace Parduotuve
{
    partial class DeliveryAndPurchase
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
            this.InternatDeliveryRB = new System.Windows.Forms.RadioButton();
            this.SSTDeliveryRB = new System.Windows.Forms.RadioButton();
            this.CourierDeliveryRB = new System.Windows.Forms.RadioButton();
            this.PostDeliveryRB = new System.Windows.Forms.RadioButton();
            this.DeliveryLbl = new System.Windows.Forms.Label();
            this.DeliveryAddressLbl = new System.Windows.Forms.Label();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.BasketPriceLbl = new System.Windows.Forms.Label();
            this.WeightCatLbl = new System.Windows.Forms.Label();
            this.DeliveryPriceLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.TrueBasketPriceLbl = new System.Windows.Forms.Label();
            this.TrueWeightCatLbl = new System.Windows.Forms.Label();
            this.TrueDeliveryLbl = new System.Windows.Forms.Label();
            this.TrueTotalLbl = new System.Windows.Forms.Label();
            this.CompleteOrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InternatDeliveryRB
            // 
            this.InternatDeliveryRB.AutoSize = true;
            this.InternatDeliveryRB.Location = new System.Drawing.Point(414, 59);
            this.InternatDeliveryRB.Name = "InternatDeliveryRB";
            this.InternatDeliveryRB.Size = new System.Drawing.Size(212, 21);
            this.InternatDeliveryRB.TabIndex = 4;
            this.InternatDeliveryRB.TabStop = true;
            this.InternatDeliveryRB.Text = "International delivery 10.99 €";
            this.InternatDeliveryRB.UseVisualStyleBackColor = true;
            this.InternatDeliveryRB.Click += new System.EventHandler(this.RB_Click);
            // 
            // SSTDeliveryRB
            // 
            this.SSTDeliveryRB.AutoSize = true;
            this.SSTDeliveryRB.Location = new System.Drawing.Point(414, 23);
            this.SSTDeliveryRB.Name = "SSTDeliveryRB";
            this.SSTDeliveryRB.Size = new System.Drawing.Size(239, 21);
            this.SSTDeliveryRB.TabIndex = 3;
            this.SSTDeliveryRB.TabStop = true;
            this.SSTDeliveryRB.Text = "Self-service post terminals 1.99 €";
            this.SSTDeliveryRB.UseVisualStyleBackColor = true;
            this.SSTDeliveryRB.Click += new System.EventHandler(this.RB_Click);
            // 
            // CourierDeliveryRB
            // 
            this.CourierDeliveryRB.AutoSize = true;
            this.CourierDeliveryRB.Location = new System.Drawing.Point(160, 59);
            this.CourierDeliveryRB.Name = "CourierDeliveryRB";
            this.CourierDeliveryRB.Size = new System.Drawing.Size(243, 21);
            this.CourierDeliveryRB.TabIndex = 2;
            this.CourierDeliveryRB.TabStop = true;
            this.CourierDeliveryRB.Text = "Home delivery (via courier) 5.99 €";
            this.CourierDeliveryRB.UseVisualStyleBackColor = true;
            this.CourierDeliveryRB.Click += new System.EventHandler(this.RB_Click);
            // 
            // PostDeliveryRB
            // 
            this.PostDeliveryRB.AutoSize = true;
            this.PostDeliveryRB.Location = new System.Drawing.Point(160, 23);
            this.PostDeliveryRB.Name = "PostDeliveryRB";
            this.PostDeliveryRB.Size = new System.Drawing.Size(226, 21);
            this.PostDeliveryRB.TabIndex = 1;
            this.PostDeliveryRB.TabStop = true;
            this.PostDeliveryRB.Text = "Home delivery (via post) 2.99 €";
            this.PostDeliveryRB.UseVisualStyleBackColor = true;
            this.PostDeliveryRB.Click += new System.EventHandler(this.RB_Click);
            // 
            // DeliveryLbl
            // 
            this.DeliveryLbl.Location = new System.Drawing.Point(24, 23);
            this.DeliveryLbl.Name = "DeliveryLbl";
            this.DeliveryLbl.Size = new System.Drawing.Size(116, 57);
            this.DeliveryLbl.TabIndex = 0;
            this.DeliveryLbl.Text = "Choose your preferred delivery method:";
            // 
            // DeliveryAddressLbl
            // 
            this.DeliveryAddressLbl.AutoSize = true;
            this.DeliveryAddressLbl.Location = new System.Drawing.Point(24, 105);
            this.DeliveryAddressLbl.Name = "DeliveryAddressLbl";
            this.DeliveryAddressLbl.Size = new System.Drawing.Size(303, 17);
            this.DeliveryAddressLbl.TabIndex = 5;
            this.DeliveryAddressLbl.Text = "Please enter your home/post terminal address:";
            // 
            // AddressTB
            // 
            this.AddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTB.Location = new System.Drawing.Point(27, 125);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(626, 24);
            this.AddressTB.TabIndex = 6;
            this.AddressTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BasketPriceLbl
            // 
            this.BasketPriceLbl.AutoSize = true;
            this.BasketPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketPriceLbl.Location = new System.Drawing.Point(24, 182);
            this.BasketPriceLbl.Name = "BasketPriceLbl";
            this.BasketPriceLbl.Size = new System.Drawing.Size(94, 18);
            this.BasketPriceLbl.TabIndex = 7;
            this.BasketPriceLbl.Text = "Basket price:";
            // 
            // WeightCatLbl
            // 
            this.WeightCatLbl.AutoSize = true;
            this.WeightCatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightCatLbl.Location = new System.Drawing.Point(24, 222);
            this.WeightCatLbl.Name = "WeightCatLbl";
            this.WeightCatLbl.Size = new System.Drawing.Size(119, 18);
            this.WeightCatLbl.TabIndex = 8;
            this.WeightCatLbl.Text = "Weight category:";
            // 
            // DeliveryPriceLbl
            // 
            this.DeliveryPriceLbl.AutoSize = true;
            this.DeliveryPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryPriceLbl.Location = new System.Drawing.Point(24, 264);
            this.DeliveryPriceLbl.Name = "DeliveryPriceLbl";
            this.DeliveryPriceLbl.Size = new System.Drawing.Size(100, 18);
            this.DeliveryPriceLbl.TabIndex = 9;
            this.DeliveryPriceLbl.Text = "Delivery price:";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.Location = new System.Drawing.Point(27, 324);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(62, 24);
            this.TotalLbl.TabIndex = 10;
            this.TotalLbl.Text = "Total:";
            // 
            // TrueBasketPriceLbl
            // 
            this.TrueBasketPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueBasketPriceLbl.Location = new System.Drawing.Point(559, 182);
            this.TrueBasketPriceLbl.Name = "TrueBasketPriceLbl";
            this.TrueBasketPriceLbl.Size = new System.Drawing.Size(94, 18);
            this.TrueBasketPriceLbl.TabIndex = 11;
            this.TrueBasketPriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TrueWeightCatLbl
            // 
            this.TrueWeightCatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueWeightCatLbl.Location = new System.Drawing.Point(559, 222);
            this.TrueWeightCatLbl.Name = "TrueWeightCatLbl";
            this.TrueWeightCatLbl.Size = new System.Drawing.Size(94, 18);
            this.TrueWeightCatLbl.TabIndex = 12;
            this.TrueWeightCatLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TrueDeliveryLbl
            // 
            this.TrueDeliveryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueDeliveryLbl.Location = new System.Drawing.Point(559, 264);
            this.TrueDeliveryLbl.Name = "TrueDeliveryLbl";
            this.TrueDeliveryLbl.Size = new System.Drawing.Size(94, 18);
            this.TrueDeliveryLbl.TabIndex = 13;
            this.TrueDeliveryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TrueTotalLbl
            // 
            this.TrueTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueTotalLbl.Location = new System.Drawing.Point(562, 324);
            this.TrueTotalLbl.Name = "TrueTotalLbl";
            this.TrueTotalLbl.Size = new System.Drawing.Size(91, 24);
            this.TrueTotalLbl.TabIndex = 14;
            this.TrueTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompleteOrderBtn
            // 
            this.CompleteOrderBtn.Enabled = false;
            this.CompleteOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteOrderBtn.Location = new System.Drawing.Point(210, 403);
            this.CompleteOrderBtn.Name = "CompleteOrderBtn";
            this.CompleteOrderBtn.Size = new System.Drawing.Size(229, 65);
            this.CompleteOrderBtn.TabIndex = 15;
            this.CompleteOrderBtn.Text = "Complete order!";
            this.CompleteOrderBtn.UseVisualStyleBackColor = true;
            this.CompleteOrderBtn.Click += new System.EventHandler(this.CompleteOrderBtn_Click);
            // 
            // DeliveryAndPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 521);
            this.Controls.Add(this.CompleteOrderBtn);
            this.Controls.Add(this.TrueTotalLbl);
            this.Controls.Add(this.TrueDeliveryLbl);
            this.Controls.Add(this.TrueWeightCatLbl);
            this.Controls.Add(this.TrueBasketPriceLbl);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.DeliveryPriceLbl);
            this.Controls.Add(this.WeightCatLbl);
            this.Controls.Add(this.BasketPriceLbl);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.DeliveryAddressLbl);
            this.Controls.Add(this.InternatDeliveryRB);
            this.Controls.Add(this.SSTDeliveryRB);
            this.Controls.Add(this.DeliveryLbl);
            this.Controls.Add(this.CourierDeliveryRB);
            this.Controls.Add(this.PostDeliveryRB);
            this.Name = "DeliveryAndPurchase";
            this.Text = "Delivery and purchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DeliveryLbl;
        private System.Windows.Forms.RadioButton InternatDeliveryRB;
        private System.Windows.Forms.RadioButton SSTDeliveryRB;
        private System.Windows.Forms.RadioButton CourierDeliveryRB;
        private System.Windows.Forms.RadioButton PostDeliveryRB;
        private System.Windows.Forms.Label DeliveryAddressLbl;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label BasketPriceLbl;
        private System.Windows.Forms.Label WeightCatLbl;
        private System.Windows.Forms.Label DeliveryPriceLbl;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label TrueBasketPriceLbl;
        private System.Windows.Forms.Label TrueWeightCatLbl;
        private System.Windows.Forms.Label TrueDeliveryLbl;
        private System.Windows.Forms.Label TrueTotalLbl;
        private System.Windows.Forms.Button CompleteOrderBtn;
    }
}