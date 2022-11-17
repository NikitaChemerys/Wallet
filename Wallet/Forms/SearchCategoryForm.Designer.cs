namespace Wallet.Forms {
  partial class SearchCategoryForm {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      this.CategoryValidationLbl = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.CategoryCBox = new System.Windows.Forms.ComboBox();
      this.RaportTBox = new System.Windows.Forms.TextBox();
      this.SearchBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();

      this.CategoryValidationLbl.AutoSize = true;
      this.CategoryValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.CategoryValidationLbl.Location = new System.Drawing.Point(123, 38);
      this.CategoryValidationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.CategoryValidationLbl.Name = "CategoryValidationLbl";
      this.CategoryValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.CategoryValidationLbl.TabIndex = 120;
      this.CategoryValidationLbl.Text = "*";

      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(22, 38);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 16);
      this.label1.TabIndex = 119;
      this.label1.Text = "Category:";

      this.CategoryCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CategoryCBox.DropDownWidth = 250;
      this.CategoryCBox.FormattingEnabled = true;
      this.CategoryCBox.Location = new System.Drawing.Point(158, 34);
      this.CategoryCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.CategoryCBox.Name = "CategoryCBox";
      this.CategoryCBox.Size = new System.Drawing.Size(252, 24);
      this.CategoryCBox.TabIndex = 118;

      this.RaportTBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.RaportTBox.Location = new System.Drawing.Point(16, 68);
      this.RaportTBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.RaportTBox.Multiline = true;
      this.RaportTBox.Name = "RaportTBox";
      this.RaportTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.RaportTBox.Size = new System.Drawing.Size(981, 515);
      this.RaportTBox.TabIndex = 121;
      this.RaportTBox.TabStop = false;

      this.SearchBtn.Location = new System.Drawing.Point(431, 32);
      this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.SearchBtn.Name = "SearchBtn";
      this.SearchBtn.Size = new System.Drawing.Size(100, 28);
      this.SearchBtn.TabIndex = 122;
      this.SearchBtn.Text = "Search";
      this.SearchBtn.UseVisualStyleBackColor = true;
      this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);

      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1015, 615);
      this.Controls.Add(this.SearchBtn);
      this.Controls.Add(this.RaportTBox);
      this.Controls.Add(this.CategoryValidationLbl);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.CategoryCBox);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SearchCategoryForm";
      this.Text = "Search by categories";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label CategoryValidationLbl;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox CategoryCBox;
    private System.Windows.Forms.TextBox RaportTBox;
    private System.Windows.Forms.Button SearchBtn;
  }
}