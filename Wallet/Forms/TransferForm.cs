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
  public partial class TransferForm : Form {
    private int _selectedRowIndex = 0;
    private Bill _selectedBill = new Bill();
    private Validation _validation = new Validation();
    private BillProvider _BillProvider = new BillProvider();
    private List<Bill> _BillList = new List<Bill>();
    private List<Bill> _FromBillList = new List<Bill>();
    private List<Bill> _ToBillList = new List<Bill>();
    private bool _isFromBill = false;

    public TransferForm() {
      InitializeComponent();
      DataLoad();
      LoadAllDate();
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        SetDataInBillList();
        _BillProvider.SaveBill(_BillList);
        ClearAllControls();
        DataLoad();
      }
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void LoadAllDate() {
      _FromBillList = GetBill(_BillList);
      FromBillCBox.DataSource = _FromBillList;
      FromBillCBox.ValueMember = "BillId";
      FromBillCBox.DisplayMember = "BillName";

      _ToBillList = GetBill(_BillList);
      ToBillCBox.DataSource = _ToBillList;
      ToBillCBox.ValueMember = "BillId";
      ToBillCBox.DisplayMember = "BillName";

      _isFromBill = true;
      FromBillCBox_SelectedIndexChanged(FromBillCBox, EventArgs.Empty);
    }

    private List<Bill> GetBill(List<Bill> BillList) { 
      List<Bill> billList = new List<Bill>();
      for (int i = 0; i < BillList.Count; i++) {
        billList.Add(BillList[i]);
      }
      return billList;
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
      if (Convert.ToInt32(FromBillCBox.SelectedValue) == Convert.ToInt32(ToBillCBox.SelectedValue)) {
        MessageBox.Show("It is not possible to transfer money to the same account!", "Warning!");
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
      FromBillCBox_SelectedIndexChanged(FromBillCBox, EventArgs.Empty);
    }

    private void SetDataInBillList() {
      for (int i = 0; i < _BillList.Count; i++) {
        if (Convert.ToInt32(ToBillCBox.SelectedValue) == _BillList[i].BillId) {
          _BillList[i].ProfitSumma += Convert.ToDouble(ProfitSummaTBox.Text);
          _BillList[i].SpendingSumma += Convert.ToDouble(SpendingSummaTBox.Text);
        }
      }

      for (int i = 0; i < _BillList.Count; i++) {
        if (Convert.ToInt32(FromBillCBox.SelectedValue) == _BillList[i].BillId) {
          _BillList[i].ProfitSumma -= Convert.ToDouble(ProfitSummaTBox.Text);
          _BillList[i].SpendingSumma -= Convert.ToDouble(SpendingSummaTBox.Text);
        }
      }
    }

    private void FromBillCBox_SelectedIndexChanged(object sender, EventArgs e) {
      if (_isFromBill) {
        _selectedBill = SelectBill(Convert.ToInt32(FromBillCBox.SelectedValue), _BillList);
        GetSelectBill(_selectedBill);
      }
    }

    private void GetSelectBill(Bill SelectedBill) {
      ProfitLbl.Text = "Profit: " + SelectedBill.ProfitSumma.ToString();
      SpendingLbl.Text = "Spending: " + SelectedBill.SpendingSumma.ToString();
    }

    private Bill SelectBill(int BillId, List<Bill> BillList) {
      for (int i = 0; i < BillList.Count; i++) {
        if (BillId == BillList[i].BillId) {
          return BillList[i];
        }
      }
      return (new Bill());
    }


  }
}
