using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Wallet.Provider {
 public class StoryProvider {
    private BinaryFormatter formatter = new BinaryFormatter();

    public void SaveStory(List<Story> listStory) {
      using (FileStream fs = new FileStream("Story.dat", FileMode.OpenOrCreate)) {
        formatter.Serialize(fs, listStory);
      }
    }
    public List<Story> GetAllStory() {
      List<Story> allStoryList = new List<Story>();
      using (FileStream fs = new FileStream("Story.dat", FileMode.OpenOrCreate)) {
        if (fs.Length != 0) {
          List<Story> deserilizeStory = (List<Story>)formatter.Deserialize(fs);
          foreach (Story story in deserilizeStory) {
            allStoryList.Add(story);
          }
        }
      }
      return allStoryList;
    }

  }
}

[Serializable]
public class Story {
  private DateTime _StoryDateTime;
  private double _SpendingSumma;
  private double _ProfitSumma;
  private string _BillName;
  private int _CategoryId;

  public Story() {
    _StoryDateTime = new DateTime();
    _SpendingSumma = 0.0;
    _ProfitSumma = 0.0;
    _BillName = String.Empty;
    _CategoryId = 0;
  }

  public Story(DateTime StoryDateTime, double SpendingSumma, double ProfitSumma, string BillName, int CategoryId) {
    _StoryDateTime = StoryDateTime;
    _SpendingSumma = SpendingSumma;
    _ProfitSumma = ProfitSumma;
    _BillName = BillName;
    _CategoryId = CategoryId;
  }

  public DateTime StoryDateTime {
    set { _StoryDateTime = value; }
    get { return _StoryDateTime; }
  }
  public double SpendingSumma {
    set { _SpendingSumma = value; }
    get { return _SpendingSumma; }
  }
  public double ProfitSumma {
    set { _ProfitSumma = value; }
    get { return _ProfitSumma; }
  }
  public string BillName {
    set { _BillName = value; }
    get { return _BillName; }
  }
  public int CategoryId {
    set { _CategoryId = value; }
    get { return _CategoryId; }
  }
}