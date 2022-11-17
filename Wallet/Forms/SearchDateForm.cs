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
  public partial class SearchDateForm : Form {
    private StoryProvider _StoryProvider = new StoryProvider();
    public static List<Story> _StoryList = new List<Story>();

    public SearchDateForm() {
      InitializeComponent();
      _StoryList = _StoryProvider.GetAllStory();
    }

    private void SearchBtn_Click(object sender, EventArgs e) {
      GetRaport(_StoryList);
    }

    public void GetRaport(List<Story> StoryList) {

      RaportTBox.Text = "Search by selected date:\r\n";
      RaportTBox.Text += "\r\n";
      RaportTBox.Text += "--------------------------------------------\r\n";

      RaportTBox.Text += String.Format("{0, -60}|{1, 9:N1}|{2, 9:N1}|\r\n",
        "Bill", "Spending", "Profits");
      for (int i = 0; i < StoryList.Count; i++) {
        if (StoryDateTimeDTP.Value.ToShortDateString() == StoryList[i].StoryDateTime.ToShortDateString()) {
          string raportString = String.Format("{0, -60}|{1, 9:N1}|{2, 9:N1}|\r\n",
          StoryList[i].BillName, StoryList[i].SpendingSumma, StoryList[i].ProfitSumma);
          RaportTBox.Text += raportString;
        }
      }
    }
  }
}
