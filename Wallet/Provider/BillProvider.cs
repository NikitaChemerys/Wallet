using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Wallet.Provider {
  public class BillProvider {
    private BinaryFormatter formatter = new BinaryFormatter();

    public void SaveBill(List<Bill> listBill) {
      using (FileStream fs = new FileStream("Bill.dat", FileMode.OpenOrCreate)) {
        formatter.Serialize(fs, listBill);
      }
    }
    public List<Bill> GetAllBill() {
      List<Bill> allBillList = new List<Bill>();
      using (FileStream fs = new FileStream("Bill.dat", FileMode.Open)) {
        List<Bill> deserilizeBill = (List<Bill>)formatter.Deserialize(fs);
        foreach (Bill bill in deserilizeBill) {
          allBillList.Add(bill);
        }
      }
      return allBillList;
    }
  }
}

[Serializable]
public class Bill {
  private int _BillId;
  private string _BillName;
  private string _Description;
  private double _SpendingSumma;
  private double _ProfitSumma;
  private int _CategoryId;
  private bool _IsDelete;

  public Bill() {
    _BillId = 0;
    _BillName = String.Empty;
    _Description = String.Empty;
    _SpendingSumma = 0.0;
    _ProfitSumma = 0.0;
    _CategoryId = 0;
    _IsDelete = false;
  }

  public Bill(int BillId, string BillName, string Description, double SpendingSumma, double ProfitSumma, int CategoryId) {
    _BillId = BillId;
    _BillName = BillName;
    _Description = Description;
    _SpendingSumma = SpendingSumma;
    _ProfitSumma = ProfitSumma;
    _CategoryId = CategoryId;
  }

  public int BillId {
    set { _BillId = value; }
    get { return _BillId; }
  }
  public string BillName {
    set { _BillName = value; }
    get { return _BillName; }
  }
  public string Description {
    set { _Description = value; }
    get { return _Description; }
  }
  public double SpendingSumma {
    set { _SpendingSumma = value; }
    get { return _SpendingSumma; }
  }
  public double ProfitSumma {
    set { _ProfitSumma = value; }
    get { return _ProfitSumma; }
  }
  public int CategoryId {
    set { _CategoryId = value; }
    get { return _CategoryId; }
  }
  public bool IsDelete {
    set { _IsDelete = value; }
    get { return _IsDelete; }
  }
}
