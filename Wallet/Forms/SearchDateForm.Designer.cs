namespace Wallet.Forms {
  partial class SearchDateForm {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      this.SearchBtn = new System.Windows.Forms.Button();
      this.RaportTBox = new System.Windows.Forms.TextBox();
      this.CategoryValidationLbl = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.StoryDateTimeDTP = new System.Windows.Forms.DateTimePicker();
      this.SuspendLayout();

      this.SearchBtn.Location = new System.Drawing.Point(364, 17);
      this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
      this.SearchBtn.Name = "SearchBtn";
      this.SearchBtn.Size = new System.Drawing.Size(100, 28);
      this.SearchBtn.TabIndex = 127;
      this.SearchBtn.Text = "Search";
      this.SearchBtn.UseVisualStyleBackColor = true;
      this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);

      this.RaportTBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.RaportTBox.Location = new System.Drawing.Point(18, 53);
      this.RaportTBox.Margin = new System.Windows.Forms.Padding(4);
      this.RaportTBox.Multiline = true;
      this.RaportTBox.Name = "RaportTBox";
      this.RaportTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.RaportTBox.Size = new System.Drawing.Size(981, 515);
      this.RaportTBox.TabIndex = 126;
      this.RaportTBox.TabStop = false;

      this.CategoryValidationLbl.AutoSize = true;
      this.CategoryValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.CategoryValidationLbl.Location = new System.Drawing.Point(125, 23);
      this.CategoryValidationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.CategoryValidationLbl.Name = "CategoryValidationLbl";
      this.CategoryValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.CategoryValidationLbl.TabIndex = 125;
      this.CategoryValidationLbl.Text = "*";

      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(58, 23);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 16);
      this.label1.TabIndex = 124;
      this.label1.Text = "Date:";

      this.StoryDateTimeDTP.Location = new System.Drawing.Point(157, 18);
      this.StoryDateTimeDTP.Name = "StoryDateTimeDTP";
      this.StoryDateTimeDTP.Size = new System.Drawing.Size(200, 22);
      this.StoryDateTimeDTP.TabIndex = 128;

      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1034, 598);
      this.Controls.Add(this.StoryDateTimeDTP);
      this.Controls.Add(this.SearchBtn);
      this.Controls.Add(this.RaportTBox);
      this.Controls.Add(this.CategoryValidationLbl);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SearchDateForm";
      this.Text = "Search by date";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button SearchBtn;
    private System.Windows.Forms.TextBox RaportTBox;
    private System.Windows.Forms.Label CategoryValidationLbl;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker StoryDateTimeDTP;
  }
}