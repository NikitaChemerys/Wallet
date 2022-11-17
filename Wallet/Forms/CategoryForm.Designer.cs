namespace Wallet.Forms {
  partial class CategoryForm {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.CategoryGridView = new System.Windows.Forms.DataGridView();
      this.CategoryIdValiadtionLbl = new System.Windows.Forms.Label();
      this.CategoryNameTBox = new System.Windows.Forms.TextBox();
      this.CategoryIdTBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.LastNameValiadtionLbl = new System.Windows.Forms.Label();
      this.DescriptionTBox = new System.Windows.Forms.TextBox();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.ClearBtn = new System.Windows.Forms.Button();
      this.AddBtn = new System.Windows.Forms.Button();
      this.AddressLbl = new System.Windows.Forms.Label();
      this.LastNameLbl = new System.Windows.Forms.Label();
      this.AddSotrudnikGBox = new System.Windows.Forms.GroupBox();
      this.AddPanel = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
      this.AddSotrudnikGBox.SuspendLayout();
      this.AddPanel.SuspendLayout();
      this.SuspendLayout();

      this.CategoryGridView.AllowUserToAddRows = false;
      this.CategoryGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.CategoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.CategoryGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.CategoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.CategoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CategoryGridView.GridColor = System.Drawing.SystemColors.Control;
      this.CategoryGridView.Location = new System.Drawing.Point(376, 0);
      this.CategoryGridView.MultiSelect = false;
      this.CategoryGridView.Name = "CategoryGridView";
      this.CategoryGridView.ReadOnly = true;
      this.CategoryGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CategoryGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.CategoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.CategoryGridView.Size = new System.Drawing.Size(577, 504);
      this.CategoryGridView.TabIndex = 85;
      this.CategoryGridView.TabStop = false;
      this.CategoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellClick);

      this.CategoryIdValiadtionLbl.AutoSize = true;
      this.CategoryIdValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.CategoryIdValiadtionLbl.Location = new System.Drawing.Point(114, 24);
      this.CategoryIdValiadtionLbl.Name = "CategoryIdValiadtionLbl";
      this.CategoryIdValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.CategoryIdValiadtionLbl.TabIndex = 27;
      this.CategoryIdValiadtionLbl.Text = "*";

      this.CategoryNameTBox.Location = new System.Drawing.Point(132, 49);
      this.CategoryNameTBox.MaxLength = 200;
      this.CategoryNameTBox.Name = "CategoryNameTBox";
      this.CategoryNameTBox.Size = new System.Drawing.Size(190, 22);
      this.CategoryNameTBox.TabIndex = 2;

      this.CategoryIdTBox.Location = new System.Drawing.Point(132, 21);
      this.CategoryIdTBox.MaxLength = 200;
      this.CategoryIdTBox.Name = "CategoryIdTBox";
      this.CategoryIdTBox.Size = new System.Drawing.Size(190, 22);
      this.CategoryIdTBox.TabIndex = 1;
      this.CategoryIdTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(6, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(105, 16);
      this.label2.TabIndex = 25;
      this.label2.Text = "ID:";

      this.LastNameValiadtionLbl.AutoSize = true;
      this.LastNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.LastNameValiadtionLbl.Location = new System.Drawing.Point(113, 50);
      this.LastNameValiadtionLbl.Name = "LastNameValiadtionLbl";
      this.LastNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.LastNameValiadtionLbl.TabIndex = 22;
      this.LastNameValiadtionLbl.Text = "*";

      this.DescriptionTBox.Location = new System.Drawing.Point(71, 85);
      this.DescriptionTBox.MaxLength = 300;
      this.DescriptionTBox.Multiline = true;
      this.DescriptionTBox.Name = "DescriptionTBox";
      this.DescriptionTBox.Size = new System.Drawing.Size(251, 142);
      this.DescriptionTBox.TabIndex = 5;

      this.ExitBtn.Location = new System.Drawing.Point(241, 243);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 8;
      this.ExitBtn.Text = "Exit";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);

      this.ClearBtn.Location = new System.Drawing.Point(142, 243);
      this.ClearBtn.Name = "ClearBtn";
      this.ClearBtn.Size = new System.Drawing.Size(81, 23);
      this.ClearBtn.TabIndex = 7;
      this.ClearBtn.Text = "Clear";
      this.ClearBtn.UseVisualStyleBackColor = true;
      this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);

      this.AddBtn.Location = new System.Drawing.Point(40, 243);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(81, 23);
      this.AddBtn.TabIndex = 6;
      this.AddBtn.Text = "Add";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);

      this.AddressLbl.AutoSize = true;
      this.AddressLbl.Location = new System.Drawing.Point(6, 85);
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

      this.AddSotrudnikGBox.Controls.Add(this.CategoryIdValiadtionLbl);
      this.AddSotrudnikGBox.Controls.Add(this.CategoryNameTBox);
      this.AddSotrudnikGBox.Controls.Add(this.CategoryIdTBox);
      this.AddSotrudnikGBox.Controls.Add(this.label2);
      this.AddSotrudnikGBox.Controls.Add(this.LastNameValiadtionLbl);
      this.AddSotrudnikGBox.Controls.Add(this.DescriptionTBox);
      this.AddSotrudnikGBox.Controls.Add(this.ExitBtn);
      this.AddSotrudnikGBox.Controls.Add(this.ClearBtn);
      this.AddSotrudnikGBox.Controls.Add(this.AddBtn);
      this.AddSotrudnikGBox.Controls.Add(this.AddressLbl);
      this.AddSotrudnikGBox.Controls.Add(this.LastNameLbl);
      this.AddSotrudnikGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddSotrudnikGBox.Location = new System.Drawing.Point(12, 12);
      this.AddSotrudnikGBox.Name = "AddSotrudnikGBox";
      this.AddSotrudnikGBox.Size = new System.Drawing.Size(358, 282);
      this.AddSotrudnikGBox.TabIndex = 0;
      this.AddSotrudnikGBox.TabStop = false;
      this.AddSotrudnikGBox.Text = "Add";

      this.AddPanel.Controls.Add(this.AddSotrudnikGBox);
      this.AddPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.AddPanel.Location = new System.Drawing.Point(0, 0);
      this.AddPanel.Name = "AddPanel";
      this.AddPanel.Size = new System.Drawing.Size(376, 504);
      this.AddPanel.TabIndex = 84;

      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(953, 504);
      this.Controls.Add(this.CategoryGridView);
      this.Controls.Add(this.AddPanel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CategoryForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Category";
      ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
      this.AddSotrudnikGBox.ResumeLayout(false);
      this.AddSotrudnikGBox.PerformLayout();
      this.AddPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView CategoryGridView;
    private System.Windows.Forms.Label CategoryIdValiadtionLbl;
    private System.Windows.Forms.TextBox CategoryNameTBox;
    private System.Windows.Forms.TextBox CategoryIdTBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label LastNameValiadtionLbl;
    private System.Windows.Forms.TextBox DescriptionTBox;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.Button ClearBtn;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.Label AddressLbl;
    private System.Windows.Forms.Label LastNameLbl;
    private System.Windows.Forms.GroupBox AddSotrudnikGBox;
    private System.Windows.Forms.Panel AddPanel;
  }
}