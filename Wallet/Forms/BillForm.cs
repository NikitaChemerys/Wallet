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
  public partial class BillForm : Form {
    public static Bill _selectedBill = new Bill();
    private int _selectedRowIndex = 0;
    private Validation _validation = new Validation();
    private BillProvider _BillProvider = new BillProvider();
    public static List<Bill> _BillList = new List<Bill>();
    private CategoryProvider _CategoryProvider = new CategoryProvider();
    private List<Category> _CategoryList = new List<Category>();

    public BillForm() {
      InitializeComponent();
      LoadAllDate();
      DataLoad();
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        Bill Bill = new Bill(Convert.ToInt32(BillIdTBox.Text), BillNameTBox.Text, DescriptionTBox.Text, 0, 0, Convert.ToInt32(CategoryCBox.SelectedValue));
        _BillList.Add(Bill);
        _BillProvider.SaveBill(_BillList);
        DataLoad();
        ClearAllControls();
      }
    }

    private void ClearBtn_Click(object sender, EventArgs e) {
      ClearAllControls();
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void LoadAllDate() {
      _CategoryList = _CategoryProvider.GetAllCategory();
      CategoryCBox.DataSource = _CategoryList;
      CategoryCBox.ValueMember = "CategoryId";
      CategoryCBox.DisplayMember = "CategoryName";
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

      DataGridViewColumn LastNameColumn = new DataGridViewTextBoxColumn();
      LastNameColumn.HeaderText = "Bills";
      LastNameColumn.DataPropertyName = "BillName";
      LastNameColumn.Width = 350;
      BillGridView.Columns.Add(LastNameColumn);

      for (int i = 0; i < BillGridView.Columns.Count; i++) {
        BillGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
      }

    }

    private void ClearAllControls() {
      BillIdTBox.Text = "0";
      BillNameTBox.Text = String.Empty;
      DescriptionTBox.Text = String.Empty;
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataConvertToInt(BillIdTBox.Text)) {
        BillIdValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        BillIdValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (!IsBillIdExist(Convert.ToInt32(BillIdTBox.Text), _BillList)) {
        BillIdValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        MessageBox.Show("Such an identifier already exists in the system.\r\n Please enter another one!", "Warning!");
        BillIdValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(BillNameTBox.Text)) {
        BillNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        BillNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (Convert.ToInt32(CategoryCBox.SelectedValue) > 0) {
        CategoryValidationLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        CategoryValidationLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }


    private bool IsBillIdExist(int BillId, List<Bill> BillList) {
      for (int i = 0; i < BillList.Count; i++) {
        if (BillId == BillList[i].BillId) {
          return true;
        }
      }
      return false;
    }

    private void SetDataInBillList() {
      for (int i = 0; i < _BillList.Count; i++) {
        if (_selectedBill.BillId == _BillList[i].BillId) {
          _BillList[i].BillName = _selectedBill.BillName;
          _BillList[i].Description = _selectedBill.Description;
        }
      }
    }

    private Bill SelectBill(int BillId, List<Bill> BillList) {
      for (int i = 0; i < BillList.Count; i++) {
        if (BillId == BillList[i].BillId) {
          return BillList[i];
        }
      }
      return (new Bill());
    }

    private void DeleteBillInfo(int BillId) {
      for (int i = 0; i < _BillList.Count; i++) {
        if (BillId == _BillList[i].BillId) {
          _BillList.RemoveAt(i);
        }
      }
    }

    private void BillGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex >= 0) {
        _selectedRowIndex = e.RowIndex;
        _selectedBill = SelectBill(Convert.ToInt32(BillGridView[0, e.RowIndex].Value.ToString()), _BillList);
        UpdateBillForm updateBillForm = new UpdateBillForm();
        updateBillForm.ShowDialog();
        if (_selectedBill.IsDelete) {
          DeleteBillInfo(_selectedBill.BillId);
        } else {
          SetDataInBillList();
        }
        _BillProvider.SaveBill(_BillList);
        DataLoad();
      }
    }

  }
}
