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
  public partial class RaportDayForm : Form {
    private StoryProvider _StoryProvider = new StoryProvider();
    public static List<Story> _StoryList = new List<Story>();

    public RaportDayForm() {
      InitializeComponent();
      _StoryList = _StoryProvider.GetAllStory();
    }

    private void SearchBtn_Click(object sender, EventArgs e) {
      GetRaport(_StoryList);
    }

    public void GetRaport(List<Story> StoryList) {

      RaportTBox.Text = "Report on selected days " + FromDTP.Value.ToShortDateString() + " to " + ToDTP.Value.ToShortDateString() + ":\r\n";
      RaportTBox.Text += "\r\n";
      RaportTBox.Text += "--------------------------------------------\r\n";

      RaportTBox.Text += String.Format("{0, -60}|{1, 9:N1}|{2, 9:N1}|\r\n",
        "Bill", "Spending", "Profits");
      for (int i = 0; i < StoryList.Count; i++) {
        if (FromDTP.Value.Date <= StoryList[i].StoryDateTime.Date && ToDTP.Value.Date >= StoryList[i].StoryDateTime.Date) {
          string raportString = String.Format("{0, -60}|{1, 9:N1}|{2, 9:N1}|\r\n",
          StoryList[i].BillName, StoryList[i].SpendingSumma, StoryList[i].ProfitSumma);
          RaportTBox.Text += raportString;
        }
      }
    }
  }
}
