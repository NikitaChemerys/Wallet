using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallet.Provider;

namespace Wallet.BLL {
  public class RaportCategoryBLL {
    private StoryProvider _StoryProvider = new StoryProvider();
    public static List<Story> _StoryList = new List<Story>();
    private CategoryProvider _CategoryProvider = new CategoryProvider();
    private List<Category> _CategoryList = new List<Category>();

    public List<RaportCategoty> GetAllRaportCategoty() {
      List<RaportCategoty> _RaportCategotyList = new List<RaportCategoty>();
      _StoryList = _StoryProvider.GetAllStory();
      _CategoryList = _CategoryProvider.GetAllCategory();

      for (int i = 0; i < _CategoryList.Count; i++) {
        RaportCategoty oneRaportCategoty = new RaportCategoty();
        oneRaportCategoty.Number = _CategoryList[i].CategoryId;
        oneRaportCategoty.CategoryName = _CategoryList[i].CategoryName;
        oneRaportCategoty.Profit = GetProfit(_CategoryList[i].CategoryId, _StoryList);
        oneRaportCategoty.Spending = GetSpending(_CategoryList[i].CategoryId, _StoryList);
        _RaportCategotyList.Add(oneRaportCategoty);
      }

      return _RaportCategotyList;
    }

    private double GetProfit(int CategoryId, List<Story> StoryList) {
      double profit = 0.0;
      for (int i = 0; i < StoryList.Count; i++) {
        if (CategoryId == StoryList[i].CategoryId) {
          profit += StoryList[i].ProfitSumma;
        }
      }
      return profit;
    }

    private double GetSpending(int CategoryId, List<Story> StoryList) {
      double spending = 0.0;
      for (int i = 0; i < StoryList.Count; i++) {
        if (CategoryId == StoryList[i].CategoryId) {
          spending += StoryList[i].SpendingSumma;
        }
      }
      return spending;
    }

  }
}

public class RaportCategoty {
  private int _Number;
  private string _CategoryName;
  private double _Profit;
  private double _Spending;

  public RaportCategoty() {
    _Number = 0;
    _CategoryName = String.Empty;
    _Profit = 0;
    _Spending = 0;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public string CategoryName {
    set { _CategoryName = value; }
    get { return _CategoryName; }
  }
  public double Profit {
    set { _Profit = value; }
    get { return _Profit; }
  }
  public double Spending {
    set { _Spending = value; }
    get { return _Spending; }
  }

}
