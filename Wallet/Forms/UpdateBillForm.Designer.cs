namespace Wallet.Forms {
  partial class UpdateBillForm {

    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      this.AddSotrudnikGBox = new System.Windows.Forms.GroupBox();
      this.CategoryValidationLbl = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.CategoryCBox = new System.Windows.Forms.ComboBox();
      this.BillNameTBox = new System.Windows.Forms.TextBox();
      this.BillNameValiadtionLbl = new System.Windows.Forms.Label();
      this.DescriptionTBox = new System.Windows.Forms.TextBox();
      this.AddressLbl = new System.Windows.Forms.Label();
      this.LastNameLbl = new System.Windows.Forms.Label();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.DeleteBtn = new System.Windows.Forms.Button();
      this.SaveBtn = new System.Windows.Forms.Button();
      this.AddSotrudnikGBox.SuspendLayout();
      this.SuspendLayout();

      this.AddSotrudnikGBox.Controls.Add(this.ExitBtn);
      this.AddSotrudnikGBox.Controls.Add(this.DeleteBtn);
      this.AddSotrudnikGBox.Controls.Add(this.SaveBtn);
      this.AddSotrudnikGBox.Controls.Add(this.CategoryValidationLbl);
      this.AddSotrudnikGBox.Controls.Add(this.label1);
      this.AddSotrudnikGBox.Controls.Add(this.CategoryCBox);
      this.AddSotrudnikGBox.Controls.Add(this.BillNameTBox);
      this.AddSotrudnikGBox.Controls.Add(this.BillNameValiadtionLbl);
      this.AddSotrudnikGBox.Controls.Add(this.DescriptionTBox);
      this.AddSotrudnikGBox.Controls.Add(this.AddressLbl);
      this.AddSotrudnikGBox.Controls.Add(this.LastNameLbl);
      this.AddSotrudnikGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddSotrudnikGBox.Location = new System.Drawing.Point(12, 12);
      this.AddSotrudnikGBox.Name = "AddSotrudnikGBox";
      this.AddSotrudnikGBox.Size = new System.Drawing.Size(358, 308);
      this.AddSotrudnikGBox.TabIndex = 1;
      this.AddSotrudnikGBox.TabStop = false;

      this.CategoryValidationLbl.AutoSize = true;
      this.CategoryValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.CategoryValidationLbl.Location = new System.Drawing.Point(113, 50);
      this.CategoryValidationLbl.Name = "CategoryValidationLbl";
      this.CategoryValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.CategoryValidationLbl.TabIndex = 117;
      this.CategoryValidationLbl.Text = "*";

      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 16);
      this.label1.TabIndex = 116;
      this.label1.Text = "Category:";

      this.CategoryCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CategoryCBox.DropDownWidth = 250;
      this.CategoryCBox.FormattingEnabled = true;
      this.CategoryCBox.Location = new System.Drawing.Point(132, 47);
      this.CategoryCBox.Name = "CategoryCBox";
      this.CategoryCBox.Size = new System.Drawing.Size(190, 24);
      this.CategoryCBox.TabIndex = 115;

      this.BillNameTBox.Location = new System.Drawing.Point(132, 17);
      this.BillNameTBox.MaxLength = 200;
      this.BillNameTBox.Name = "BillNameTBox";
      this.BillNameTBox.Size = new System.Drawing.Size(190, 22);
      this.BillNameTBox.TabIndex = 2;

      this.BillNameValiadtionLbl.AutoSize = true;
      this.BillNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.BillNameValiadtionLbl.Location = new System.Drawing.Point(113, 18);
      this.BillNameValiadtionLbl.Name = "BillNameValiadtionLbl";
      this.BillNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.BillNameValiadtionLbl.TabIndex = 22;
      this.BillNameValiadtionLbl.Text = "*";

      this.DescriptionTBox.Location = new System.Drawing.Point(71, 105);
      this.DescriptionTBox.MaxLength = 300;
      this.DescriptionTBox.Multiline = true;
      this.DescriptionTBox.Name = "DescriptionTBox";
      this.DescriptionTBox.Size = new System.Drawing.Size(251, 142);
      this.DescriptionTBox.TabIndex = 5;

      this.AddressLbl.AutoSize = true;
      this.AddressLbl.Location = new System.Drawing.Point(6, 105);
      this.AddressLbl.Name = "AddressLbl";
      this.AddressLbl.Size = new System.Drawing.Size(44, 16);
      this.AddressLbl.TabIndex = 5;
      this.AddressLbl.Text = "About:";

      this.LastNameLbl.AutoSize = true;
      this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LastNameLbl.Location = new System.Drawing.Point(6, 18);
      this.LastNameLbl.Name = "LastNameLbl";
      this.LastNameLbl.Size = new System.Drawing.Size(53, 16);
      this.LastNameLbl.TabIndex = 1;
      this.LastNameLbl.Text = "Name:";

      this.ExitBtn.Location = new System.Drawing.Point(243, 270);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 120;
      this.ExitBtn.Text = "Exit";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);

      this.DeleteBtn.Location = new System.Drawing.Point(145, 270);
      this.DeleteBtn.Name = "DeleteBtn";
      this.DeleteBtn.Size = new System.Drawing.Size(81, 23);
      this.DeleteBtn.TabIndex = 119;
      this.DeleteBtn.Text = "Delete";
      this.DeleteBtn.UseVisualStyleBackColor = true;
      this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);

      this.SaveBtn.Location = new System.Drawing.Point(46, 270);
      this.SaveBtn.Name = "SaveBtn";
      this.SaveBtn.Size = new System.Drawing.Size(81, 23);
      this.SaveBtn.TabIndex = 118;
      this.SaveBtn.Text = "Save";
      this.SaveBtn.UseVisualStyleBackColor = true;
      this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);

      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(387, 338);
      this.Controls.Add(this.AddSotrudnikGBox);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UpdateBillForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Update";
      this.AddSotrudnikGBox.ResumeLayout(false);
      this.AddSotrudnikGBox.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox AddSotrudnikGBox;
    private System.Windows.Forms.Label CategoryValidationLbl;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox CategoryCBox;
    private System.Windows.Forms.TextBox BillNameTBox;
    private System.Windows.Forms.Label BillNameValiadtionLbl;
    private System.Windows.Forms.TextBox DescriptionTBox;
    private System.Windows.Forms.Label AddressLbl;
    private System.Windows.Forms.Label LastNameLbl;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.Button DeleteBtn;
    private System.Windows.Forms.Button SaveBtn;
  }
}