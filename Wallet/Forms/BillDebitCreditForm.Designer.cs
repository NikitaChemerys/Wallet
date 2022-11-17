namespace Wallet.Forms {
  partial class BillDebitCreditForm {

    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label1 = new System.Windows.Forms.Label();
      this.ProfitSummaValiadtionLbl = new System.Windows.Forms.Label();
      this.SpendingSummaTBox = new System.Windows.Forms.TextBox();
      this.ProfitSummaTBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SpendingSummaValiadtionLbl = new System.Windows.Forms.Label();
      this.DescriptionTBox = new System.Windows.Forms.TextBox();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.AddPanel = new System.Windows.Forms.Panel();
      this.AddSotrudnikGBox = new System.Windows.Forms.GroupBox();
      this.NameLbl = new System.Windows.Forms.Label();
      this.AddBtn = new System.Windows.Forms.Button();
      this.AddressLbl = new System.Windows.Forms.Label();
      this.BillGridView = new System.Windows.Forms.DataGridView();
      this.BillNameTBox = new System.Windows.Forms.TextBox();
      this.AddPanel.SuspendLayout();
      this.AddSotrudnikGBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
      this.SuspendLayout();

      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 16);
      this.label1.TabIndex = 116;
      this.label1.Text = "Bill:";

      this.ProfitSummaValiadtionLbl.AutoSize = true;
      this.ProfitSummaValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.ProfitSummaValiadtionLbl.Location = new System.Drawing.Point(114, 55);
      this.ProfitSummaValiadtionLbl.Name = "ProfitSummaValiadtionLbl";
      this.ProfitSummaValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.ProfitSummaValiadtionLbl.TabIndex = 27;
      this.ProfitSummaValiadtionLbl.Text = "*";

      this.SpendingSummaTBox.Location = new System.Drawing.Point(132, 80);
      this.SpendingSummaTBox.MaxLength = 200;
      this.SpendingSummaTBox.Name = "SpendingSummaTBox";
      this.SpendingSummaTBox.Size = new System.Drawing.Size(190, 22);
      this.SpendingSummaTBox.TabIndex = 2;
      this.SpendingSummaTBox.Text = "0";
      this.SpendingSummaTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

      this.ProfitSummaTBox.Location = new System.Drawing.Point(132, 52);
      this.ProfitSummaTBox.MaxLength = 200;
      this.ProfitSummaTBox.Name = "ProfitSummaTBox";
      this.ProfitSummaTBox.Size = new System.Drawing.Size(190, 22);
      this.ProfitSummaTBox.TabIndex = 1;
      this.ProfitSummaTBox.Text = "0";
      this.ProfitSummaTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(6, 55);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 16);
      this.label2.TabIndex = 25;
      this.label2.Text = "Profit:";

      this.SpendingSummaValiadtionLbl.AutoSize = true;
      this.SpendingSummaValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.SpendingSummaValiadtionLbl.Location = new System.Drawing.Point(113, 81);
      this.SpendingSummaValiadtionLbl.Name = "SpendingSummaValiadtionLbl";
      this.SpendingSummaValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.SpendingSummaValiadtionLbl.TabIndex = 22;
      this.SpendingSummaValiadtionLbl.Text = "*";

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
 
      this.AddPanel.Controls.Add(this.AddSotrudnikGBox);
      this.AddPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.AddPanel.Location = new System.Drawing.Point(0, 0);
      this.AddPanel.Name = "AddPanel";
      this.AddPanel.Size = new System.Drawing.Size(376, 472);
      this.AddPanel.TabIndex = 88;

      this.AddSotrudnikGBox.Controls.Add(this.BillNameTBox);
      this.AddSotrudnikGBox.Controls.Add(this.label2);
      this.AddSotrudnikGBox.Controls.Add(this.NameLbl);
      this.AddSotrudnikGBox.Controls.Add(this.label1);
      this.AddSotrudnikGBox.Controls.Add(this.ProfitSummaValiadtionLbl);
      this.AddSotrudnikGBox.Controls.Add(this.SpendingSummaValiadtionLbl);
      this.AddSotrudnikGBox.Controls.Add(this.DescriptionTBox);
      this.AddSotrudnikGBox.Controls.Add(this.SpendingSummaTBox);
      this.AddSotrudnikGBox.Controls.Add(this.ExitBtn);
      this.AddSotrudnikGBox.Controls.Add(this.ProfitSummaTBox);
      this.AddSotrudnikGBox.Controls.Add(this.AddBtn);
      this.AddSotrudnikGBox.Controls.Add(this.AddressLbl);
      this.AddSotrudnikGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddSotrudnikGBox.Location = new System.Drawing.Point(12, 12);
      this.AddSotrudnikGBox.Name = "AddSotrudnikGBox";
      this.AddSotrudnikGBox.Size = new System.Drawing.Size(358, 342);
      this.AddSotrudnikGBox.TabIndex = 0;
      this.AddSotrudnikGBox.TabStop = false;

      this.NameLbl.AutoSize = true;
      this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.NameLbl.Location = new System.Drawing.Point(6, 81);
      this.NameLbl.Name = "NameLbl";
      this.NameLbl.Size = new System.Drawing.Size(66, 16);
      this.NameLbl.TabIndex = 1;
      this.NameLbl.Text = "Spending:";

      this.AddBtn.Location = new System.Drawing.Point(132, 295);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(86, 23);
      this.AddBtn.TabIndex = 6;
      this.AddBtn.Text = "Save";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);

      this.AddressLbl.AutoSize = true;
      this.AddressLbl.Location = new System.Drawing.Point(6, 137);
      this.AddressLbl.Name = "AddressLbl";
      this.AddressLbl.Size = new System.Drawing.Size(44, 16);
      this.AddressLbl.TabIndex = 5;
      this.AddressLbl.Text = "About:";

      this.BillGridView.AllowUserToAddRows = false;
      this.BillGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.BillGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
      this.BillGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.BillGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.BillGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BillGridView.GridColor = System.Drawing.SystemColors.Control;
      this.BillGridView.Location = new System.Drawing.Point(376, 0);
      this.BillGridView.MultiSelect = false;
      this.BillGridView.Name = "BillGridView";
      this.BillGridView.ReadOnly = true;
      this.BillGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.BillGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
      this.BillGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.BillGridView.Size = new System.Drawing.Size(591, 472);
      this.BillGridView.TabIndex = 89;
      this.BillGridView.TabStop = false;
      this.BillGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillGridView_CellClick);

      this.BillNameTBox.Enabled = false;
      this.BillNameTBox.Location = new System.Drawing.Point(132, 21);
      this.BillNameTBox.MaxLength = 200;
      this.BillNameTBox.Name = "BillNameTBox";
      this.BillNameTBox.Size = new System.Drawing.Size(190, 22);
      this.BillNameTBox.TabIndex = 118;

      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(967, 472);
      this.Controls.Add(this.BillGridView);
      this.Controls.Add(this.AddPanel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "BillDebitCreditForm";
      this.Text = "Profit/Spending";
      this.AddPanel.ResumeLayout(false);
      this.AddSotrudnikGBox.ResumeLayout(false);
      this.AddSotrudnikGBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label ProfitSummaValiadtionLbl;
    private System.Windows.Forms.TextBox SpendingSummaTBox;
    private System.Windows.Forms.TextBox ProfitSummaTBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label SpendingSummaValiadtionLbl;
    private System.Windows.Forms.TextBox DescriptionTBox;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.Panel AddPanel;
    private System.Windows.Forms.GroupBox AddSotrudnikGBox;
    private System.Windows.Forms.Label NameLbl;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.Label AddressLbl;
    private System.Windows.Forms.DataGridView BillGridView;
    private System.Windows.Forms.TextBox BillNameTBox;
  }
}