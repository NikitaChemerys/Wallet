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
  public partial class UpdateBillForm : Form {
    private Validation _validation = new Validation();
    private CategoryProvider _CategoryProvider = new CategoryProvider();
    private List<Category> _CategoryList = new List<Category>();

    public UpdateBillForm() {
      InitializeComponent();
      LoadAllDate();
    }

    private void SaveBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        SaveData();
        this.Close();
      }
    }

    private void DeleteBtn_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes) {
        CategoryForm._selectedCategory.IsDelete = true; ;
        this.Close();
      }
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void LoadAllDate() {
      _CategoryList = _CategoryProvider.GetAllCategory();
      CategoryCBox.DataSource = _CategoryList;
      CategoryCBox.ValueMember = "CategoryId";
      CategoryCBox.DisplayMember = "CategoryName";

      CategoryCBox.SelectedValue = BillForm._selectedBill.CategoryId;
      BillNameTBox.Text = BillForm._selectedBill.BillName;
      DescriptionTBox.Text = BillForm._selectedBill.Description;

    }

    private void SaveData() {
      BillForm._selectedBill.BillName = BillNameTBox.Text;
      BillForm._selectedBill.Description = DescriptionTBox.Text;
      BillForm._selectedBill.CategoryId = Convert.ToInt32(CategoryCBox.SelectedValue);
    }


    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
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
  }
}
