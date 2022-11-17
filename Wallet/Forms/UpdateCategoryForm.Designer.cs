namespace Wallet.Forms {
  partial class UpdateCategoryForm {
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
      this.CategoryNameTBox = new System.Windows.Forms.TextBox();
      this.LastNameValiadtionLbl = new System.Windows.Forms.Label();
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
      this.AddSotrudnikGBox.Controls.Add(this.CategoryNameTBox);
      this.AddSotrudnikGBox.Controls.Add(this.LastNameValiadtionLbl);
      this.AddSotrudnikGBox.Controls.Add(this.DescriptionTBox);
      this.AddSotrudnikGBox.Controls.Add(this.AddressLbl);
      this.AddSotrudnikGBox.Controls.Add(this.LastNameLbl);
      this.AddSotrudnikGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddSotrudnikGBox.Location = new System.Drawing.Point(12, 12);
      this.AddSotrudnikGBox.Name = "AddSotrudnikGBox";
      this.AddSotrudnikGBox.Size = new System.Drawing.Size(335, 261);
      this.AddSotrudnikGBox.TabIndex = 1;
      this.AddSotrudnikGBox.TabStop = false;

      this.CategoryNameTBox.Location = new System.Drawing.Point(132, 17);
      this.CategoryNameTBox.MaxLength = 200;
      this.CategoryNameTBox.Name = "CategoryNameTBox";
      this.CategoryNameTBox.Size = new System.Drawing.Size(190, 22);
      this.CategoryNameTBox.TabIndex = 2;

      this.LastNameValiadtionLbl.AutoSize = true;
      this.LastNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.LastNameValiadtionLbl.Location = new System.Drawing.Point(113, 18);
      this.LastNameValiadtionLbl.Name = "LastNameValiadtionLbl";
      this.LastNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.LastNameValiadtionLbl.TabIndex = 22;
      this.LastNameValiadtionLbl.Text = "*";

      this.DescriptionTBox.Location = new System.Drawing.Point(71, 53);
      this.DescriptionTBox.MaxLength = 300;
      this.DescriptionTBox.Multiline = true;
      this.DescriptionTBox.Name = "DescriptionTBox";
      this.DescriptionTBox.Size = new System.Drawing.Size(251, 142);
      this.DescriptionTBox.TabIndex = 5;

      this.AddressLbl.AutoSize = true;
      this.AddressLbl.Location = new System.Drawing.Point(6, 53);
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

      this.ExitBtn.Location = new System.Drawing.Point(242, 221);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 33;
      this.ExitBtn.Text = "Exit";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);

      this.DeleteBtn.Location = new System.Drawing.Point(144, 221);
      this.DeleteBtn.Name = "DeleteBtn";
      this.DeleteBtn.Size = new System.Drawing.Size(81, 23);
      this.DeleteBtn.TabIndex = 32;
      this.DeleteBtn.Text = "Delete";
      this.DeleteBtn.UseVisualStyleBackColor = true;
      this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);

      this.SaveBtn.Location = new System.Drawing.Point(45, 221);
      this.SaveBtn.Name = "SaveBtn";
      this.SaveBtn.Size = new System.Drawing.Size(81, 23);
      this.SaveBtn.TabIndex = 31;
      this.SaveBtn.Text = "Save";
      this.SaveBtn.UseVisualStyleBackColor = true;
      this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);

      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(356, 286);
      this.Controls.Add(this.AddSotrudnikGBox);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UpdateCategoryForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Edit";
      this.AddSotrudnikGBox.ResumeLayout(false);
      this.AddSotrudnikGBox.PerformLayout();
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox AddSotrudnikGBox;
    private System.Windows.Forms.TextBox CategoryNameTBox;
    private System.Windows.Forms.Label LastNameValiadtionLbl;
    private System.Windows.Forms.TextBox DescriptionTBox;
    private System.Windows.Forms.Label AddressLbl;
    private System.Windows.Forms.Label LastNameLbl;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.Button DeleteBtn;
    private System.Windows.Forms.Button SaveBtn;
  }
}