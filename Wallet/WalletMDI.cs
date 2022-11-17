using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallet.Forms;

namespace Wallet {
  public partial class WalletMDI : Form {
    public WalletMDI() {
      InitializeComponent();
    }

    public void CloseAllWindows() {
      Form[] childArray = this.MdiChildren;
      foreach (Form childForm in childArray) {
        childForm.Close();
      }
    }

    private void billToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      BillDebitCreditForm billDebitCreditForm = new BillDebitCreditForm();
      billDebitCreditForm.MdiParent = this;
      billDebitCreditForm.WindowState = FormWindowState.Maximized;
      billDebitCreditForm.Show();
    }

    private void transferMoneyToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      TransferForm transferForm = new TransferForm();
      transferForm.MdiParent = this;
      transferForm.WindowState = FormWindowState.Maximized;
      transferForm.Show();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void categoryToolStripMenuItem1_Click(object sender, EventArgs e) {
      CloseAllWindows();
      CategoryForm categoryForm = new CategoryForm();
      categoryForm.MdiParent = this;
      categoryForm.WindowState = FormWindowState.Maximized;
      categoryForm.Show();
    }

    private void billsToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      BillForm billForm = new BillForm();
      billForm.MdiParent = this;
      billForm.WindowState = FormWindowState.Maximized;
      billForm.Show();
    }

    private void categoryToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      SearchCategoryForm searchCategoryForm = new SearchCategoryForm();
      searchCategoryForm.MdiParent = this;
      searchCategoryForm.WindowState = FormWindowState.Maximized;
      searchCategoryForm.Show();
    }

    private void sumByDateToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      SearchDateForm searchDateForm = new SearchDateForm();
      searchDateForm.MdiParent = this;
      searchDateForm.WindowState = FormWindowState.Maximized;
      searchDateForm.Show();
    }

    private void byDaysToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      RaportDayForm raportDayForm = new RaportDayForm();
      raportDayForm.MdiParent = this;
      raportDayForm.WindowState = FormWindowState.Maximized;
      raportDayForm.Show();
    }

    private void byCategoriesToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      RaportCategoryForm raportCategoryForm = new RaportCategoryForm();
      raportCategoryForm.MdiParent = this;
      raportCategoryForm.WindowState = FormWindowState.Maximized;
      raportCategoryForm.Show();
    }


  }
}
