namespace Wallet.Forms {
  partial class TransferForm {
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
      this.AddSotrudnikGBox = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.ToBillCBox = new System.Windows.Forms.ComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.FromBillCBox = new System.Windows.Forms.ComboBox();
      this.NameLbl = new System.Windows.Forms.Label();
      this.ProfitSummaTBox = new System.Windows.Forms.TextBox();
      this.ProfitSummaValiadtionLbl = new System.Windows.Forms.Label();
      this.SpendingSummaTBox = new System.Windows.Forms.TextBox();
      this.SpendingSummaValiadtionLbl = new System.Windows.Forms.Label();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.AddBtn = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.BillGridView = new System.Windows.Forms.DataGridView();
      this.ProfitLbl = new System.Windows.Forms.Label();
      this.SpendingLbl = new System.Windows.Forms.Label();
      this.AddSotrudnikGBox.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
      this.SuspendLayout();

      this.AddSotrudnikGBox.Controls.Add(this.groupBox2);
      this.AddSotrudnikGBox.Controls.Add(this.groupBox1);
      this.AddSotrudnikGBox.Controls.Add(this.ExitBtn);
      this.AddSotrudnikGBox.Controls.Add(this.AddBtn);
      this.AddSotrudnikGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddSotrudnikGBox.Location = new System.Drawing.Point(12, 12);
      this.AddSotrudnikGBox.Name = "AddSotrudnikGBox";
      this.AddSotrudnikGBox.Size = new System.Drawing.Size(358, 315);
      this.AddSotrudnikGBox.TabIndex = 1;
      this.AddSotrudnikGBox.TabStop = false;
      this.AddSotrudnikGBox.Text = "Transfer";

      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.ToBillCBox);
      this.groupBox2.Location = new System.Drawing.Point(6, 191);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(335, 79);
      this.groupBox2.TabIndex = 125;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Transfer to:";

      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(6, 29);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(65, 16);
      this.label3.TabIndex = 118;
      this.label3.Text = "Bill:";

      this.ToBillCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ToBillCBox.DropDownWidth = 250;
      this.ToBillCBox.FormattingEnabled = true;
      this.ToBillCBox.Location = new System.Drawing.Point(132, 26);
      this.ToBillCBox.Name = "ToBillCBox";
      this.ToBillCBox.Size = new System.Drawing.Size(190, 24);
      this.ToBillCBox.TabIndex = 117;

      this.groupBox1.Controls.Add(this.ProfitLbl);
      this.groupBox1.Controls.Add(this.SpendingLbl);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.FromBillCBox);
      this.groupBox1.Controls.Add(this.NameLbl);
      this.groupBox1.Controls.Add(this.ProfitSummaTBox);
      this.groupBox1.Controls.Add(this.ProfitSummaValiadtionLbl);
      this.groupBox1.Controls.Add(this.SpendingSummaTBox);
      this.groupBox1.Controls.Add(this.SpendingSummaValiadtionLbl);
      this.groupBox1.Location = new System.Drawing.Point(6, 21);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(335, 164);
      this.groupBox1.TabIndex = 124;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Transfer from:";

      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 16);
      this.label1.TabIndex = 116;
      this.label1.Text = "Bill:";

      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(5, 68);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 16);
      this.label2.TabIndex = 122;
      this.label2.Text = "Profit:";

      this.FromBillCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.FromBillCBox.DropDownWidth = 250;
      this.FromBillCBox.FormattingEnabled = true;
      this.FromBillCBox.Location = new System.Drawing.Point(132, 34);
      this.FromBillCBox.Name = "FromBillCBox";
      this.FromBillCBox.Size = new System.Drawing.Size(190, 24);
      this.FromBillCBox.TabIndex = 115;
      this.FromBillCBox.SelectedIndexChanged += new System.EventHandler(this.FromBillCBox_SelectedIndexChanged);

      this.NameLbl.AutoSize = true;
      this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.NameLbl.Location = new System.Drawing.Point(5, 94);
      this.NameLbl.Name = "NameLbl";
      this.NameLbl.Size = new System.Drawing.Size(66, 16);
      this.NameLbl.TabIndex = 118;
      this.NameLbl.Text = "Spending:";

      this.ProfitSummaTBox.Location = new System.Drawing.Point(131, 65);
      this.ProfitSummaTBox.MaxLength = 200;
      this.ProfitSummaTBox.Name = "ProfitSummaTBox";
      this.ProfitSummaTBox.Size = new System.Drawing.Size(190, 22);
      this.ProfitSummaTBox.TabIndex = 119;
      this.ProfitSummaTBox.Text = "0";
      this.ProfitSummaTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

      this.ProfitSummaValiadtionLbl.AutoSize = true;
      this.ProfitSummaValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.ProfitSummaValiadtionLbl.Location = new System.Drawing.Point(113, 68);
      this.ProfitSummaValiadtionLbl.Name = "ProfitSummaValiadtionLbl";
      this.ProfitSummaValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.ProfitSummaValiadtionLbl.TabIndex = 123;
      this.ProfitSummaValiadtionLbl.Text = "*";

      this.SpendingSummaTBox.Location = new System.Drawing.Point(131, 93);
      this.SpendingSummaTBox.MaxLength = 200;
      this.SpendingSummaTBox.Name = "SpendingSummaTBox";
      this.SpendingSummaTBox.Size = new System.Drawing.Size(190, 22);
      this.SpendingSummaTBox.TabIndex = 120;
      this.SpendingSummaTBox.Text = "0";
      this.SpendingSummaTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

      this.SpendingSummaValiadtionLbl.AutoSize = true;
      this.SpendingSummaValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.SpendingSummaValiadtionLbl.Location = new System.Drawing.Point(112, 94);
      this.SpendingSummaValiadtionLbl.Name = "SpendingSummaValiadtionLbl";
      this.SpendingSummaValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.SpendingSummaValiadtionLbl.TabIndex = 121;
      this.SpendingSummaValiadtionLbl.Text = "*";

      this.ExitBtn.Location = new System.Drawing.Point(260, 276);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 8;
      this.ExitBtn.Text = "Exit";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);

      this.AddBtn.Location = new System.Drawing.Point(140, 276);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(90, 23);
      this.AddBtn.TabIndex = 6;
      this.AddBtn.Text = "Transfer";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);

      this.panel1.Controls.Add(this.AddSotrudnikGBox);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(384, 585);
      this.panel1.TabIndex = 2;

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
      this.BillGridView.Location = new System.Drawing.Point(384, 0);
      this.BillGridView.MultiSelect = false;
      this.BillGridView.Name = "BillGridView";
      this.BillGridView.ReadOnly = true;
      this.BillGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.BillGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
      this.BillGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.BillGridView.Size = new System.Drawing.Size(490, 585);
      this.BillGridView.TabIndex = 90;
      this.BillGridView.TabStop = false;

      this.ProfitLbl.AutoSize = true;
      this.ProfitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ProfitLbl.Location = new System.Drawing.Point(131, 118);
      this.ProfitLbl.Name = "ProfitLbl";
      this.ProfitLbl.Size = new System.Drawing.Size(75, 16);
      this.ProfitLbl.TabIndex = 125;
      this.ProfitLbl.Text = "Profit:";

      this.SpendingLbl.AutoSize = true;
      this.SpendingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SpendingLbl.Location = new System.Drawing.Point(131, 142);
      this.SpendingLbl.Name = "SpendingLbl";
      this.SpendingLbl.Size = new System.Drawing.Size(66, 16);
      this.SpendingLbl.TabIndex = 124;
      this.SpendingLbl.Text = "Spending:";

      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(874, 585);
      this.Controls.Add(this.BillGridView);
      this.Controls.Add(this.panel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TransferForm";
      this.Text = "Transferring money";
      this.AddSotrudnikGBox.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox AddSotrudnikGBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox FromBillCBox;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox ToBillCBox;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label NameLbl;
    private System.Windows.Forms.TextBox ProfitSummaTBox;
    private System.Windows.Forms.Label ProfitSummaValiadtionLbl;
    private System.Windows.Forms.TextBox SpendingSummaTBox;
    private System.Windows.Forms.Label SpendingSummaValiadtionLbl;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView BillGridView;
    private System.Windows.Forms.Label ProfitLbl;
    private System.Windows.Forms.Label SpendingLbl;
  }
}