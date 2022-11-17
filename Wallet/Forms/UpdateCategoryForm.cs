using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallet.AppCode;

namespace Wallet.Forms {
  public partial class UpdateCategoryForm : Form {
    private Validation _validation = new Validation();

    public UpdateCategoryForm() {
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
      CategoryNameTBox.Text = CategoryForm._selectedCategory.CategoryName;
      DescriptionTBox.Text = CategoryForm._selectedCategory.Description;
    }

    private void SaveData() {
      CategoryForm._selectedCategory.CategoryName = CategoryNameTBox.Text;
      CategoryForm._selectedCategory.Description = DescriptionTBox.Text;
    }


    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataEntering(CategoryNameTBox.Text)) {
        LastNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        LastNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }

  }
}
