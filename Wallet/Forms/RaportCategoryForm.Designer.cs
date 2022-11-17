namespace Wallet.Forms {
  partial class RaportCategoryForm {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      this.RaportTBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();

      this.RaportTBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.RaportTBox.Location = new System.Drawing.Point(13, 22);
      this.RaportTBox.Margin = new System.Windows.Forms.Padding(4);
      this.RaportTBox.Multiline = true;
      this.RaportTBox.Name = "RaportTBox";
      this.RaportTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.RaportTBox.Size = new System.Drawing.Size(981, 515);
      this.RaportTBox.TabIndex = 127;
      this.RaportTBox.TabStop = false;

      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1008, 557);
      this.Controls.Add(this.RaportTBox);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RaportCategoryForm";
      this.Text = "By categories";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox RaportTBox;
  }
}