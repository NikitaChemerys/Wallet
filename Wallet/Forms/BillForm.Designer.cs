namespace Wallet.Forms {
  partial class BillForm {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.BillGridView = new System.Windows.Forms.DataGridView();
      this.BillIdValiadtionLbl = new System.Windows.Forms.Label();
      this.BillNameTBox = new System.Windows.Forms.TextBox();
      this.BillIdTBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.BillNameValiadtionLbl = new System.Windows.Forms.Label();
      this.DescriptionTBox = new System.Windows.Forms.TextBox();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.ClearBtn = new System.Windows.Forms.Button();
      this.AddBtn = new System.Windows.Forms.Button();
      this.AddressLbl = new System.Windows.Forms.Label();
      this.LastNameLbl = new System.Windows.Forms.Label();
      this.AddSotrudnikGBox = new System.Windows.Forms.GroupBox();
      this.AddPanel = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.CategoryCBox = new System.Windows.Forms.ComboBox();
      this.CategoryValidationLbl = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
      this.AddSotrudnikGBox.SuspendLayout();
      this.AddPanel.SuspendLayout();
      this.SuspendLayout();

      this.BillGridView.AllowUserToAddRows = false;
      this.BillGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.BillGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
      this.BillGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.BillGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.BillGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BillGridView.GridColor = System.Drawing.SystemColors.Control;
      this.BillGridView.Location = new System.Drawing.Point(376, 0);
      this.BillGridView.MultiSelect = false;
      this.BillGridView.Name = "BillGridView";
      this.BillGridView.ReadOnly = true;
      this.BillGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.BillGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
      this.BillGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.BillGridView.Size = new System.Drawing.Size(518, 544);
      this.BillGridView.TabIndex = 87;
      this.BillGridView.TabStop = false;
      this.BillGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillGridView_CellClick);

      this.BillIdValiadtionLbl.AutoSize = true;
      this.BillIdValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.BillIdValiadtionLbl.Location = new System.Drawing.Point(114, 24);
      this.BillIdValiadtionLbl.Name = "BillIdValiadtionLbl";
      this.BillIdValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.BillIdValiadtionLbl.TabIndex = 27;
      this.BillIdValiadtionLbl.Text = "*";

      this.BillNameTBox.Location = new System.Drawing.Point(132, 49);
      this.BillNameTBox.MaxLength = 200;
      this.BillNameTBox.Name = "BillNameTBox";
      this.BillNameTBox.Size = new System.Drawing.Size(190, 22);
      this.BillNameTBox.TabIndex = 2;

      this.BillIdTBox.Location = new System.Drawing.Point(132, 21);
      this.BillIdTBox.MaxLength = 200;
      this.BillIdTBox.Name = "BillIdTBox";
      this.BillIdTBox.Size = new System.Drawing.Size(190, 22);
      this.BillIdTBox.TabIndex = 1;
      this.BillIdTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(6, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(105, 16);
      this.label2.TabIndex = 25;
      this.label2.Text = "ID:";

      this.BillNameValiadtionLbl.AutoSize = true;
      this.BillNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.BillNameValiadtionLbl.Location = new System.Drawing.Point(113, 50);
      this.BillNameValiadtionLbl.Name = "BillNameValiadtionLbl";
      this.BillNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.BillNameValiadtionLbl.TabIndex = 22;
      this.BillNameValiadtionLbl.Text = "*";

      this.DescriptionTBox.Location = new System.Drawing.Point(71, 137);
      this.DescriptionTBox.MaxLength = 300;
      this.DescriptionTBox.Multiline = true;
      this.DescriptionTBox.Name = "DescriptionTBox";
      this.DescriptionTBox.Size = new System.Drawing.Size(251, 142);
      this.DescriptionTBox.TabIndex = 5;

      this.ExitBtn.Location = new System.Drawing.Point(241, 295);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 8;
      this.ExitBtn.Text = "Exit";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);

      this.ClearBtn.Location = new System.Drawing.Point(142, 295);
      this.ClearBtn.Name = "ClearBtn";
      this.ClearBtn.Size = new System.Drawing.Size(81, 23);
      this.ClearBtn.TabIndex = 7;
      this.ClearBtn.Text = "Clear";
      this.ClearBtn.UseVisualStyleBackColor = true;
      this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);

      this.AddBtn.Location = new System.Drawing.Point(40, 295);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(81, 23);
      this.AddBtn.TabIndex = 6;
      this.AddBtn.Text = "Add";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);

      this.AddressLbl.AutoSize = true;
      this.AddressLbl.Location = new System.Drawing.Point(6, 137);
      this.AddressLbl.Name = "AddressLbl";
      this.AddressLbl.Size = new System.Drawing.Size(44, 16);
      this.AddressLbl.TabIndex = 5;
      this.AddressLbl.Text = "About:";

      this.LastNameLbl.AutoSize = true;
      this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LastNameLbl.Location = new System.Drawing.Point(6, 50);
      this.LastNameLbl.Name = "LastNameLbl";
      this.LastNameLbl.Size = new System.Drawing.Size(53, 16);
      this.LastNameLbl.TabIndex = 1;
      this.LastNameLbl.Text = "Name:";

      this.AddSotrudnikGBox.Controls.Add(this.CategoryValidationLbl);
      this.AddSotrudnikGBox.Controls.Add(this.label1);
      this.AddSotrudnikGBox.Controls.Add(this.CategoryCBox);
      this.AddSotrudnikGBox.Controls.Add(this.BillIdValiadtionLbl);
      this.AddSotrudnikGBox.Controls.Add(this.BillNameTBox);
      this.AddSotrudnikGBox.Controls.Add(this.BillIdTBox);
      this.AddSotrudnikGBox.Controls.Add(this.label2);
      this.AddSotrudnikGBox.Controls.Add(this.BillNameValiadtionLbl);
      this.AddSotrudnikGBox.Controls.Add(this.DescriptionTBox);
      this.AddSotrudnikGBox.Controls.Add(this.ExitBtn);
      this.AddSotrudnikGBox.Controls.Add(this.ClearBtn);
      this.AddSotrudnikGBox.Controls.Add(this.AddBtn);
      this.AddSotrudnikGBox.Controls.Add(this.AddressLbl);
      this.AddSotrudnikGBox.Controls.Add(this.LastNameLbl);
      this.AddSotrudnikGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddSotrudnikGBox.Location = new System.Drawing.Point(12, 12);
      this.AddSotrudnikGBox.Name = "AddSotrudnikGBox";
      this.AddSotrudnikGBox.Size = new System.Drawing.Size(358, 342);
      this.AddSotrudnikGBox.TabIndex = 0;
      this.AddSotrudnikGBox.TabStop = false;
      this.AddSotrudnikGBox.Text = "Add";

      this.AddPanel.Controls.Add(this.AddSotrudnikGBox);
      this.AddPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.AddPanel.Location = new System.Drawing.Point(0, 0);
      this.AddPanel.Name = "AddPanel";
      this.AddPanel.Size = new System.Drawing.Size(376, 544);
      this.AddPanel.TabIndex = 86;

      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 82);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 16);
      this.label1.TabIndex = 116;
      this.label1.Text = "Category:";

      this.CategoryCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CategoryCBox.DropDownWidth = 250;
      this.CategoryCBox.FormattingEnabled = true;
      this.CategoryCBox.Location = new System.Drawing.Point(132, 79);
      this.CategoryCBox.Name = "CategoryCBox";
      this.CategoryCBox.Size = new System.Drawing.Size(190, 24);
      this.CategoryCBox.TabIndex = 115;

      this.CategoryValidationLbl.AutoSize = true;
      this.CategoryValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.CategoryValidationLbl.Location = new System.Drawing.Point(113, 82);
      this.CategoryValidationLbl.Name = "CategoryValidationLbl";
      this.CategoryValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.CategoryValidationLbl.TabIndex = 117;
      this.CategoryValidationLbl.Text = "*";

      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(894, 544);
      this.Controls.Add(this.BillGridView);
      this.Controls.Add(this.AddPanel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "BillForm";
      this.Text = "Bills";
      ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
      this.AddSotrudnikGBox.ResumeLayout(false);
      this.AddSotrudnikGBox.PerformLayout();
      this.AddPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.DataGridView BillGridView;
    private System.Windows.Forms.Label BillIdValiadtionLbl;
    private System.Windows.Forms.TextBox BillNameTBox;
    private System.Windows.Forms.TextBox BillIdTBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label BillNameValiadtionLbl;
    private System.Windows.Forms.TextBox DescriptionTBox;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.Button ClearBtn;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.Label AddressLbl;
    private System.Windows.Forms.Label LastNameLbl;
    private System.Windows.Forms.GroupBox AddSotrudnikGBox;
    private System.Windows.Forms.Panel AddPanel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox CategoryCBox;
    private System.Windows.Forms.Label CategoryValidationLbl;
  }
}