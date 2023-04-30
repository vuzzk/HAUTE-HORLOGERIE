
namespace HAUTE_HORLOGERIE
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.shopNowButton = new System.Windows.Forms.Button();
            this.mainTextLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.aboutFillerPanel = new System.Windows.Forms.Panel();
            this.shopNowPanel = new System.Windows.Forms.Panel();
            this.mainWatchRef = new System.Windows.Forms.Label();
            this.mainWatchName = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.cartButton = new System.Windows.Forms.Button();
            this.wishlistButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.brandsButton = new System.Windows.Forms.Button();
            this.serviceButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.headerFillerPanel2 = new System.Windows.Forms.Panel();
            this.headerFillerPanel1 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.shopNowPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.aboutPanel);
            this.mainPanel.Controls.Add(this.shopNowPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1229, 702);
            this.mainPanel.TabIndex = 2;
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aboutPanel.Controls.Add(this.shopNowButton);
            this.aboutPanel.Controls.Add(this.mainTextLabel);
            this.aboutPanel.Controls.Add(this.titleLabel);
            this.aboutPanel.Controls.Add(this.logoPanel);
            this.aboutPanel.Controls.Add(this.aboutFillerPanel);
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.aboutPanel.Location = new System.Drawing.Point(787, 57);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(442, 645);
            this.aboutPanel.TabIndex = 2;
            this.aboutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.aboutPanel_Paint);
            // 
            // shopNowButton
            // 
            this.shopNowButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shopNowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.shopNowButton.FlatAppearance.BorderSize = 0;
            this.shopNowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.shopNowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shopNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopNowButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopNowButton.ForeColor = System.Drawing.Color.White;
            this.shopNowButton.Location = new System.Drawing.Point(126, 446);
            this.shopNowButton.Name = "shopNowButton";
            this.shopNowButton.Size = new System.Drawing.Size(204, 42);
            this.shopNowButton.TabIndex = 5;
            this.shopNowButton.Text = "SHOP NOW";
            this.shopNowButton.UseVisualStyleBackColor = false;
            // 
            // mainTextLabel
            // 
            this.mainTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTextLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTextLabel.Location = new System.Drawing.Point(0, 291);
            this.mainTextLabel.Name = "mainTextLabel";
            this.mainTextLabel.Size = new System.Drawing.Size(442, 142);
            this.mainTextLabel.TabIndex = 4;
            this.mainTextLabel.Text = resources.GetString("mainTextLabel.Text");
            this.mainTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 233);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(442, 58);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "BEST FROM THE  WORLD OF WATCHES";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = global::HAUTE_HORLOGERIE.Properties.Resources.hhLogo;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 70);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(442, 163);
            this.logoPanel.TabIndex = 1;
            // 
            // aboutFillerPanel
            // 
            this.aboutFillerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutFillerPanel.Location = new System.Drawing.Point(0, 0);
            this.aboutFillerPanel.Name = "aboutFillerPanel";
            this.aboutFillerPanel.Size = new System.Drawing.Size(442, 70);
            this.aboutFillerPanel.TabIndex = 0;
            // 
            // shopNowPanel
            // 
            this.shopNowPanel.BackgroundImage = global::HAUTE_HORLOGERIE.Properties.Resources.mainImage1;
            this.shopNowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shopNowPanel.Controls.Add(this.mainWatchRef);
            this.shopNowPanel.Controls.Add(this.mainWatchName);
            this.shopNowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopNowPanel.Location = new System.Drawing.Point(0, 57);
            this.shopNowPanel.Name = "shopNowPanel";
            this.shopNowPanel.Size = new System.Drawing.Size(1229, 645);
            this.shopNowPanel.TabIndex = 1;
            // 
            // mainWatchRef
            // 
            this.mainWatchRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainWatchRef.AutoSize = true;
            this.mainWatchRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainWatchRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainWatchRef.ForeColor = System.Drawing.Color.White;
            this.mainWatchRef.Location = new System.Drawing.Point(578, 620);
            this.mainWatchRef.Name = "mainWatchRef";
            this.mainWatchRef.Size = new System.Drawing.Size(316, 23);
            this.mainWatchRef.TabIndex = 1;
            this.mainWatchRef.Text = "Reference: 15202IP.OO.1240IP.01";
            // 
            // mainWatchName
            // 
            this.mainWatchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mainWatchName.AutoSize = true;
            this.mainWatchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainWatchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainWatchName.ForeColor = System.Drawing.Color.White;
            this.mainWatchName.Location = new System.Drawing.Point(12, 620);
            this.mainWatchName.Name = "mainWatchName";
            this.mainWatchName.Size = new System.Drawing.Size(418, 23);
            this.mainWatchName.TabIndex = 0;
            this.mainWatchName.Text = "Audemars Piguet Royal Oak Jumbo Extra-Thin";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.headerPanel.Controls.Add(this.cartButton);
            this.headerPanel.Controls.Add(this.wishlistButton);
            this.headerPanel.Controls.Add(this.userButton);
            this.headerPanel.Controls.Add(this.brandsButton);
            this.headerPanel.Controls.Add(this.serviceButton);
            this.headerPanel.Controls.Add(this.shopButton);
            this.headerPanel.Controls.Add(this.homeButton);
            this.headerPanel.Controls.Add(this.headerFillerPanel2);
            this.headerPanel.Controls.Add(this.headerFillerPanel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1229, 57);
            this.headerPanel.TabIndex = 0;
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.Transparent;
            this.cartButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cartButton.FlatAppearance.BorderSize = 0;
            this.cartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.Image = global::HAUTE_HORLOGERIE.Properties.Resources.shopping_bag_32;
            this.cartButton.Location = new System.Drawing.Point(1003, 0);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(57, 57);
            this.cartButton.TabIndex = 7;
            this.cartButton.UseVisualStyleBackColor = false;
            // 
            // wishlistButton
            // 
            this.wishlistButton.BackColor = System.Drawing.Color.Transparent;
            this.wishlistButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.wishlistButton.FlatAppearance.BorderSize = 0;
            this.wishlistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.wishlistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wishlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wishlistButton.Image = global::HAUTE_HORLOGERIE.Properties.Resources.favorite_32;
            this.wishlistButton.Location = new System.Drawing.Point(1060, 0);
            this.wishlistButton.Name = "wishlistButton";
            this.wishlistButton.Size = new System.Drawing.Size(57, 57);
            this.wishlistButton.TabIndex = 6;
            this.wishlistButton.UseVisualStyleBackColor = false;
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.Transparent;
            this.userButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.userButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Image = global::HAUTE_HORLOGERIE.Properties.Resources.user_32;
            this.userButton.Location = new System.Drawing.Point(1117, 0);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(57, 57);
            this.userButton.TabIndex = 5;
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // brandsButton
            // 
            this.brandsButton.BackColor = System.Drawing.Color.Transparent;
            this.brandsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.brandsButton.FlatAppearance.BorderSize = 0;
            this.brandsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.brandsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brandsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandsButton.Location = new System.Drawing.Point(535, 0);
            this.brandsButton.Name = "brandsButton";
            this.brandsButton.Size = new System.Drawing.Size(160, 57);
            this.brandsButton.TabIndex = 4;
            this.brandsButton.Text = "BRANDS";
            this.brandsButton.UseVisualStyleBackColor = false;
            // 
            // serviceButton
            // 
            this.serviceButton.BackColor = System.Drawing.Color.Transparent;
            this.serviceButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.serviceButton.FlatAppearance.BorderSize = 0;
            this.serviceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.serviceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.serviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceButton.Location = new System.Drawing.Point(375, 0);
            this.serviceButton.Name = "serviceButton";
            this.serviceButton.Size = new System.Drawing.Size(160, 57);
            this.serviceButton.TabIndex = 3;
            this.serviceButton.Text = "SERVICE";
            this.serviceButton.UseVisualStyleBackColor = false;
            // 
            // shopButton
            // 
            this.shopButton.BackColor = System.Drawing.Color.Transparent;
            this.shopButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.shopButton.FlatAppearance.BorderSize = 0;
            this.shopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.shopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopButton.Location = new System.Drawing.Point(215, 0);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(160, 57);
            this.shopButton.TabIndex = 2;
            this.shopButton.Text = "SHOP";
            this.shopButton.UseVisualStyleBackColor = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.homeButton.Enabled = false;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(55, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(160, 57);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // headerFillerPanel2
            // 
            this.headerFillerPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.headerFillerPanel2.Location = new System.Drawing.Point(1174, 0);
            this.headerFillerPanel2.Name = "headerFillerPanel2";
            this.headerFillerPanel2.Size = new System.Drawing.Size(55, 57);
            this.headerFillerPanel2.TabIndex = 1;
            // 
            // headerFillerPanel1
            // 
            this.headerFillerPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerFillerPanel1.Location = new System.Drawing.Point(0, 0);
            this.headerFillerPanel1.Name = "headerFillerPanel1";
            this.headerFillerPanel1.Size = new System.Drawing.Size(55, 57);
            this.headerFillerPanel1.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1229, 702);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1245, 741);
            this.Name = "HomeForm";
            this.Text = "Haute Horlogerie - HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.aboutPanel.ResumeLayout(false);
            this.shopNowPanel.ResumeLayout(false);
            this.shopNowPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button brandsButton;
        private System.Windows.Forms.Button serviceButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel headerFillerPanel2;
        private System.Windows.Forms.Panel headerFillerPanel1;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button wishlistButton;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Panel shopNowPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel aboutFillerPanel;
        private System.Windows.Forms.Label mainTextLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button shopNowButton;
        private System.Windows.Forms.Label mainWatchName;
        private System.Windows.Forms.Label mainWatchRef;
    }
}

