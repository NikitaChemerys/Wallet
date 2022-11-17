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
  public partial class CategoryForm : Form {
    public static Category _selectedCategory = new Category();
    private int _selectedRowIndex = 0;
    private Validation _validation = new Validation();
    private CategoryProvider _CategoryProvider = new CategoryProvider();
    public static List<Category> _CategoryList = new List<Category>();

    public CategoryForm() {
      InitializeComponent();
      DataLoad();
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        Category Category = new Category(Convert.ToInt32(CategoryIdTBox.Text), CategoryNameTBox.Text, DescriptionTBox.Text);
        _CategoryList.Add(Category);
        _CategoryProvider.SaveCategory(_CategoryList);
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

    private void DataLoad() {
      int firstRowIndex = 0;
      if (CategoryGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = CategoryGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _CategoryList.Clear();
        _CategoryList = _CategoryProvider.GetAllCategory();
        LoadDataInCategoryGridView(_CategoryList);
        if (_selectedRowIndex == CategoryGridView.Rows.Count) {
          _selectedRowIndex = CategoryGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          CategoryGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          CategoryGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInCategoryGridView(List<Category> CategoryList) {
      CategoryGridView.DataSource = null;
      CategoryGridView.Columns.Clear();
      CategoryGridView.AutoGenerateColumns = false;
      CategoryGridView.RowHeadersVisible = false;

      CategoryGridView.DataSource = CategoryList;


      DataGridViewColumn DetailIdColumn = new DataGridViewTextBoxColumn();

      DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
      numberColumn.HeaderText = "№";
      numberColumn.DataPropertyName = "CategoryId";
      numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      numberColumn.Width = 60;
      CategoryGridView.Columns.Add(numberColumn);

      DataGridViewColumn LastNameColumn = new DataGridViewTextBoxColumn();
      LastNameColumn.HeaderText = "Category";
      LastNameColumn.DataPropertyName = "CategoryName";
      LastNameColumn.Width = 350;
      CategoryGridView.Columns.Add(LastNameColumn);

      for (int i = 0; i < CategoryGridView.Columns.Count; i++) {
        CategoryGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
      }

    }

    private void ClearAllControls() {
      CategoryIdTBox.Text = "0";
      CategoryNameTBox.Text = String.Empty;
      DescriptionTBox.Text = String.Empty;
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataConvertToInt(CategoryIdTBox.Text)) {
        CategoryIdValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        CategoryIdValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (!IsCategoryIdExist(Convert.ToInt32(CategoryIdTBox.Text), _CategoryList)) {
        CategoryIdValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        MessageBox.Show("Such ID already exists in the system.\r\n Please enter another one!", "Warning!");
        CategoryIdValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(CategoryNameTBox.Text)) {
        LastNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        LastNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }


    private bool IsCategoryIdExist(int CategoryId, List<Category> CategoryList) {
      for (int i = 0; i < CategoryList.Count; i++) {
        if (CategoryId == CategoryList[i].CategoryId) {
          return true;
        }
      }
      return false;
    }

    private void SetDataInCategoryList() {
      for (int i = 0; i < _CategoryList.Count; i++) {
        if (_selectedCategory.CategoryId == _CategoryList[i].CategoryId) {
          _CategoryList[i].CategoryName = _selectedCategory.CategoryName;
          _CategoryList[i].Description = _selectedCategory.Description;
        }
      }
    }

    private Category SelectCategory(int CategoryId, List<Category> CategoryList) {
      for (int i = 0; i < CategoryList.Count; i++) {
        if (CategoryId == CategoryList[i].CategoryId) {
          return CategoryList[i];
        }
      }
      return (new Category());
    }

    private void DeleteCategoryInfo(int CategoryId) {
      for (int i = 0; i < _CategoryList.Count; i++) {
        if (CategoryId == _CategoryList[i].CategoryId) {
          _CategoryList.RemoveAt(i);
        }
      }
    }

    private void CategoryGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex >= 0) {
        _selectedRowIndex = e.RowIndex;
        _selectedCategory = SelectCategory(Convert.ToInt32(CategoryGridView[0, e.RowIndex].Value.ToString()), _CategoryList);
        UpdateCategoryForm updateCategoryForm = new UpdateCategoryForm();
        updateCategoryForm.ShowDialog();
        if (_selectedCategory.IsDelete) {
          DeleteCategoryInfo(_selectedCategory.CategoryId);
        } else {
          SetDataInCategoryList();
        }
        _CategoryProvider.SaveCategory(_CategoryList);
        DataLoad();
      }
    }


  }
}
