using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallet.AppCode;
using Wallet.Provider;

namespace Wallet.Forms {
  public partial class BillDebitCreditForm : Form {
    private Bill _selectedBill = new Bill();
    private int _selectedRowIndex = 0;
    private StoryProvider _StoryProvider = new StoryProvider();
    private List<Story> _StoryList = new List<Story>();
    private Validation _validation = new Validation();
    private BillProvider _BillProvider = new BillProvider();
    public static List<Bill> _BillList = new List<Bill>();
    
    public BillDebitCreditForm() {
      InitializeComponent();
      DataLoad();
      LoadStory();
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _StoryList.Add(new Story(DateTime.Now, Convert.ToDouble(SpendingSummaTBox.Text), Convert.ToDouble(ProfitSummaTBox.Text),
         _selectedBill.BillName, _selectedBill.CategoryId));
        _StoryProvider.SaveStory(_StoryList);
        SetDataInBillList();
        _BillProvider.SaveBill(_BillList);
        ClearAllControls();
        DataLoad();
        LoadStory();
      }
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void LoadStory() {
      _StoryList.Clear();
      _StoryList = _StoryProvider.GetAllStory();
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataConvertToDouble(ProfitSummaTBox.Text)) {
        ProfitSummaValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        ProfitSummaValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataConvertToDouble(SpendingSummaTBox.Text)) {
        SpendingSummaValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        SpendingSummaValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (!_validation.IsDataEntering(BillNameTBox.Text)) {
        MessageBox.Show("No account selected!", "Warning!");
        isCorrect = false;
      }
      return isCorrect;
    }

    private void DataLoad() {
      int firstRowIndex = 0;
      if (BillGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = BillGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _BillList.Clear();
        _BillList = _BillProvider.GetAllBill();
        LoadDataInBillGridView(_BillList);
        if (_selectedRowIndex == BillGridView.Rows.Count) {
          _selectedRowIndex = BillGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          BillGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          BillGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInBillGridView(List<Bill> BillList) {
      BillGridView.DataSource = null;
      BillGridView.Columns.Clear();
      BillGridView.AutoGenerateColumns = false;
      BillGridView.RowHeadersVisible = false;

      BillGridView.DataSource = BillList;


      DataGridViewColumn DetailIdColumn = new DataGridViewTextBoxColumn();

      DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
      numberColumn.HeaderText = "№";
      numberColumn.DataPropertyName = "BillId";
      numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      numberColumn.Width = 60;
      BillGridView.Columns.Add(numberColumn);

      DataGridViewColumn BillNameColumn = new DataGridViewTextBoxColumn();
      BillNameColumn.HeaderText = "Bills";
      BillNameColumn.DataPropertyName = "BillName";
      BillNameColumn.Width = 350;
      BillGridView.Columns.Add(BillNameColumn);

      DataGridViewColumn ProfitSummaColumn = new DataGridViewTextBoxColumn();
      ProfitSummaColumn.HeaderText = "Profit ";
      ProfitSummaColumn.DataPropertyName = "ProfitSumma";
      ProfitSummaColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      ProfitSummaColumn.Width = 100;
      BillGridView.Columns.Add(ProfitSummaColumn);

      DataGridViewColumn SpendingSummaColumn = new DataGridViewTextBoxColumn();
      SpendingSummaColumn.HeaderText = "Spending";
      SpendingSummaColumn.DataPropertyName = "SpendingSumma";
      SpendingSummaColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      SpendingSummaColumn.Width = 100;
      BillGridView.Columns.Add(SpendingSummaColumn);

      for (int i = 0; i < BillGridView.Columns.Count; i++) {
        BillGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
      }

    }

    private void ClearAllControls() {
      ProfitSummaTBox.Text = "0";
      SpendingSummaTBox.Text = "0";
      BillNameTBox.Text = String.Empty;
      DescriptionTBox.Text = String.Empty;
    }

    private void BillGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      _selectedRowIndex = e.RowIndex;
      _selectedBill = SelectBill(Convert.ToInt32(BillGridView[0, e.RowIndex].Value.ToString()), _BillList);
      GetSelectBill(_selectedBill);
    }

    private void GetSelectBill(Bill SelectedBill) {
      BillNameTBox.Text = SelectedBill.BillName;
      DescriptionTBox.Text = SelectedBill.Description;
    }

    private Bill SelectBill(int BillId, List<Bill> BillList) {
      for (int i = 0; i < BillList.Count; i++) {
        if (BillId == BillList[i].BillId) {
          return BillList[i];
        }
      }
      return (new Bill());
    }

    private void SetDataInBillList() {
      for (int i = 0; i < _BillList.Count; i++) {
        if (_selectedBill.BillId == _BillList[i].BillId) {
          _BillList[i].ProfitSumma += Convert.ToDouble(ProfitSummaTBox .Text);
          _BillList[i].SpendingSumma += Convert.ToDouble(SpendingSummaTBox.Text);
          _BillList[i].Description = DescriptionTBox.Text;
        }
      }
    }

  }
}
