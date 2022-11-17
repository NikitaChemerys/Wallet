using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallet.Provider;

namespace Wallet.Forms {
  public partial class SearchCategoryForm : Form {
    private BillProvider _BillProvider = new BillProvider();
    public static List<Bill> _BillList = new List<Bill>();
    private CategoryProvider _CategoryProvider = new CategoryProvider();
    private List<Category> _CategoryList = new List<Category>();


    public SearchCategoryForm() {
      InitializeComponent();
      _BillList = _BillProvider.GetAllBill();
      LoadAllDate();
    }

    private void SearchBtn_Click(object sender, EventArgs e) {
      GetRaport(_BillList);
    }

    private void LoadAllDate() {
      _CategoryList = _CategoryProvider.GetAllCategory();
      CategoryCBox.DataSource = _CategoryList;
      CategoryCBox.ValueMember = "CategoryId";
      CategoryCBox.DisplayMember = "CategoryName";
    }

    public void GetRaport(List<Bill> BillList) {

      RaportTBox.Text = "Search by selected category:\r\n";
      RaportTBox.Text += "\r\n";
      RaportTBox.Text += "--------------------------------------------\r\n";

      RaportTBox.Text += String.Format("{0,6}|{1, -60}|{2, 9:N1}|{3, 9:N1}|\r\n",
        "№", "Bill", "Spending", "Profits");
      for (int i = 0; i < BillList.Count; i++) {
        if (Convert.ToInt32(CategoryCBox.SelectedValue) == BillList[i].CategoryId) {
          string raportString = String.Format("{0,6}|{1, -60}|{2, 9:N1}|{3, 9:N1}|\r\n",
          BillList[i].BillId, BillList[i].BillName, BillList[i].SpendingSumma, BillList[i].ProfitSumma);
          RaportTBox.Text += raportString;
        }
      }
    }

  }
}
