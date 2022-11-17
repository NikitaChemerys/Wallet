namespace Wallet.Forms {
  partial class RaportDayForm {

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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.FromDTP = new System.Windows.Forms.DateTimePicker();
      this.CategoryValidationLbl = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.ToDTP = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();

      this.SearchBtn.Location = new System.Drawing.Point(219, 73);
      this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
      this.SearchBtn.Name = "SearchBtn";
      this.SearchBtn.Size = new System.Drawing.Size(100, 28);
      this.SearchBtn.TabIndex = 127;
      this.SearchBtn.Text = "Form";
      this.SearchBtn.UseVisualStyleBackColor = true;
      this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);

      this.RaportTBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.RaportTBox.Location = new System.Drawing.Point(12, 133);
      this.RaportTBox.Margin = new System.Windows.Forms.Padding(4);
      this.RaportTBox.Multiline = true;
      this.RaportTBox.Name = "RaportTBox";
      this.RaportTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.RaportTBox.Size = new System.Drawing.Size(981, 461);
      this.RaportTBox.TabIndex = 126;
      this.RaportTBox.TabStop = false;

      this.groupBox1.Controls.Add(this.ToDTP);
      this.groupBox1.Controls.Add(this.SearchBtn);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.FromDTP);
      this.groupBox1.Controls.Add(this.CategoryValidationLbl);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(333, 114);
      this.groupBox1.TabIndex = 128;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Reporting";

      this.FromDTP.Location = new System.Drawing.Point(119, 14);
      this.FromDTP.Name = "FromDTP";
      this.FromDTP.Size = new System.Drawing.Size(200, 22);
      this.FromDTP.TabIndex = 131;

      this.CategoryValidationLbl.AutoSize = true;
      this.CategoryValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.CategoryValidationLbl.Location = new System.Drawing.Point(87, 19);
      this.CategoryValidationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.CategoryValidationLbl.Name = "CategoryValidationLbl";
      this.CategoryValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.CategoryValidationLbl.TabIndex = 130;
      this.CategoryValidationLbl.Text = "*";

      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(20, 19);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 16);
      this.label1.TabIndex = 129;
      this.label1.Text = "Start:";

      this.ToDTP.Location = new System.Drawing.Point(119, 47);
      this.ToDTP.Name = "ToDTP";
      this.ToDTP.Size = new System.Drawing.Size(200, 22);
      this.ToDTP.TabIndex = 134;

      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(87, 52);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(13, 16);
      this.label2.TabIndex = 133;
      this.label2.Text = "*";

      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(20, 52);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 16);
      this.label3.TabIndex = 132;
      this.label3.Text = "End:";

      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 654);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.RaportTBox);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RaportDayForm";
      this.Text = "By days";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button SearchBtn;
    private System.Windows.Forms.TextBox RaportTBox;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DateTimePicker ToDTP;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DateTimePicker FromDTP;
    private System.Windows.Forms.Label CategoryValidationLbl;
    private System.Windows.Forms.Label label1;
  }
}