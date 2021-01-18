
namespace Parduotuve
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.ProductsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BuyButton = new System.Windows.Forms.Button();
            this.BasketPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BasketPriceLbl = new System.Windows.Forms.Label();
            this.WeightCategoryLbl = new System.Windows.Forms.Label();
            this.TrueBasketPriceLbl = new System.Windows.Forms.Label();
            this.TrueWeightCatLbl = new System.Windows.Forms.Label();
            this.EuroLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductsPanel
            // 
            resources.ApplyResources(this.ProductsPanel, "ProductsPanel");
            this.ProductsPanel.Name = "ProductsPanel";
            // 
            // BuyButton
            // 
            resources.ApplyResources(this.BuyButton, "BuyButton");
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // BasketPanel
            // 
            resources.ApplyResources(this.BasketPanel, "BasketPanel");
            this.BasketPanel.Name = "BasketPanel";
            // 
            // BasketPriceLbl
            // 
            resources.ApplyResources(this.BasketPriceLbl, "BasketPriceLbl");
            this.BasketPriceLbl.Name = "BasketPriceLbl";
            // 
            // WeightCategoryLbl
            // 
            resources.ApplyResources(this.WeightCategoryLbl, "WeightCategoryLbl");
            this.WeightCategoryLbl.Name = "WeightCategoryLbl";
            // 
            // TrueBasketPriceLbl
            // 
            resources.ApplyResources(this.TrueBasketPriceLbl, "TrueBasketPriceLbl");
            this.TrueBasketPriceLbl.Name = "TrueBasketPriceLbl";
            // 
            // TrueWeightCatLbl
            // 
            resources.ApplyResources(this.TrueWeightCatLbl, "TrueWeightCatLbl");
            this.TrueWeightCatLbl.Name = "TrueWeightCatLbl";
            // 
            // EuroLbl
            // 
            resources.ApplyResources(this.EuroLbl, "EuroLbl");
            this.EuroLbl.Name = "EuroLbl";
            // 
            // ShopForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EuroLbl);
            this.Controls.Add(this.TrueBasketPriceLbl);
            this.Controls.Add(this.TrueWeightCatLbl);
            this.Controls.Add(this.WeightCategoryLbl);
            this.Controls.Add(this.BasketPriceLbl);
            this.Controls.Add(this.BasketPanel);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.ProductsPanel);
            this.Name = "ShopForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ProductsPanel;
        private System.Windows.Forms.Button BuyButton;
        public System.Windows.Forms.FlowLayoutPanel BasketPanel;
        private System.Windows.Forms.Label BasketPriceLbl;
        private System.Windows.Forms.Label WeightCategoryLbl;
        private System.Windows.Forms.Label TrueBasketPriceLbl;
        private System.Windows.Forms.Label TrueWeightCatLbl;
        private System.Windows.Forms.Label EuroLbl;
    }
}

