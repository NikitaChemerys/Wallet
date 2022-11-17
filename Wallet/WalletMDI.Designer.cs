namespace Wallet {
  partial class WalletMDI {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.transferMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.categoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sumByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.byDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.byCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();

      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(1408, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "MenuStrip";

      this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billToolStripMenuItem,
            this.toolStripSeparator4,
            this.transferMoneyToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
      this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
      this.fileMenu.Name = "fileMenu";
      this.fileMenu.Size = new System.Drawing.Size(82, 20);
      this.fileMenu.Text = "&Management";

      this.billToolStripMenuItem.Name = "billToolStripMenuItem";
      this.billToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
      this.billToolStripMenuItem.Text = "Profit/Spending";
      this.billToolStripMenuItem.Click += new System.EventHandler(this.billToolStripMenuItem_Click);

      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(189, 6);

      this.transferMoneyToolStripMenuItem.Name = "transferMoneyToolStripMenuItem";
      this.transferMoneyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
      this.transferMoneyToolStripMenuItem.Text = "Transferring money";
      this.transferMoneyToolStripMenuItem.Click += new System.EventHandler(this.transferMoneyToolStripMenuItem_Click);

      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(189, 6);

      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

      this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem1,
            this.billsToolStripMenuItem});
      this.editMenu.Name = "editMenu";
      this.editMenu.Size = new System.Drawing.Size(76, 20);
      this.editMenu.Text = "&Directory";

      this.categoryToolStripMenuItem1.Name = "categoryToolStripMenuItem1";
      this.categoryToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
      this.categoryToolStripMenuItem1.Text = "Category";
      this.categoryToolStripMenuItem1.Click += new System.EventHandler(this.categoryToolStripMenuItem1_Click);

      this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
      this.billsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.billsToolStripMenuItem.Text = "Profits";
      this.billsToolStripMenuItem.Click += new System.EventHandler(this.billsToolStripMenuItem_Click);

      this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.sumByDateToolStripMenuItem});
      this.viewMenu.Name = "viewMenu";
      this.viewMenu.Size = new System.Drawing.Size(58, 20);
      this.viewMenu.Text = "&Search";

      this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
      this.categoryToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.categoryToolStripMenuItem.Text = "Category";
      this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);

      this.sumByDateToolStripMenuItem.Name = "sumByDateToolStripMenuItem";
      this.sumByDateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.sumByDateToolStripMenuItem.Text = "Date";
      this.sumByDateToolStripMenuItem.Click += new System.EventHandler(this.sumByDateToolStripMenuItem_Click);

      this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byDaysToolStripMenuItem,
            this.byCategoriesToolStripMenuItem});
      this.toolsMenu.Name = "toolsMenu";
      this.toolsMenu.Size = new System.Drawing.Size(80, 20);
      this.toolsMenu.Text = "&Statistic";

      this.byDaysToolStripMenuItem.Name = "byDaysToolStripMenuItem";
      this.byDaysToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.byDaysToolStripMenuItem.Text = "By days";
      this.byDaysToolStripMenuItem.Click += new System.EventHandler(this.byDaysToolStripMenuItem_Click);

      this.byCategoriesToolStripMenuItem.Name = "byCategoriesToolStripMenuItem";
      this.byCategoriesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.byCategoriesToolStripMenuItem.Text = "By categories";
      this.byCategoriesToolStripMenuItem.Click += new System.EventHandler(this.byCategoriesToolStripMenuItem_Click);

      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1408, 726);
      this.Controls.Add(this.menuStrip);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip;
      this.Name = "WalletMDI";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Wallet";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion


    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileMenu;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editMenu;
    private System.Windows.Forms.ToolStripMenuItem viewMenu;
    private System.Windows.Forms.ToolStripMenuItem toolsMenu;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.ToolStripMenuItem transferMoneyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sumByDateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem byDaysToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem byCategoriesToolStripMenuItem;
  }
}



