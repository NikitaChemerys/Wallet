using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallet.BLL;
using Wallet.Provider;

namespace Wallet.Forms {
  public partial class RaportCategoryForm : Form {
    private RaportCategoryBLL _RaportBLL = new RaportCategoryBLL();
    private List<RaportCategoty> _RaportCategotyList = new List<RaportCategoty>();

    public RaportCategoryForm() {
      InitializeComponent();
      _RaportCategotyList = _RaportBLL.GetAllRaportCategoty();
      GetRaport(_RaportCategotyList);
    }

    public void GetRaport(List<RaportCategoty> RaportCategotyList) {

      RaportTBox.Text = "Report by categories:\r\n";
      RaportTBox.Text += "\r\n";
      RaportTBox.Text += "--------------------------------------------\r\n";

      RaportTBox.Text += String.Format("{0,6}|{1, -60}|{2, 9:N1}|{3, 9:N1}|\r\n",
        "№", "Bill", "Spending", "Profits");
      for (int i = 0; i < RaportCategotyList.Count; i++) {
          string raportString = String.Format("{0,6}|{1, -60}|{2, 9:N1}|{3, 9:N1}|\r\n",
          RaportCategotyList[i].Number, RaportCategotyList[i].CategoryName, RaportCategotyList[i].Profit, RaportCategotyList[i].Spending);
          RaportTBox.Text += raportString;
      }
    }

  }
}
