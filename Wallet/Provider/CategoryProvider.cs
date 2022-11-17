using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Wallet.Provider {
 public class CategoryProvider {
    private BinaryFormatter formatter = new BinaryFormatter();

    public void SaveCategory(List<Category> listCategory) {
      using (FileStream fs = new FileStream("Category.dat", FileMode.OpenOrCreate)) {
        formatter.Serialize(fs, listCategory);
        Console.WriteLine("Object is serialized");
      }
    }
    public List<Category> GetAllCategory() {
      List<Category> allCategoryList = new List<Category>();
      using (FileStream fs = new FileStream("Category.dat", FileMode.Open)) {
        List<Category> deserilizeCategory = (List<Category>)formatter.Deserialize(fs);
        foreach (Category Category in deserilizeCategory) {
          allCategoryList.Add(Category);
        }
      }
      return allCategoryList;
    }

  }
}

[Serializable]
public class Category {
  private int _CategoryId;
  private string _CategoryName;
  private string _Description;
  private bool _IsDelete;

  public Category() {
    _CategoryId = 0;
    _CategoryName = String.Empty;
    _Description = String.Empty;
    _IsDelete = false;
  }

  public Category(int CategoryId, string CategoryName, string Description) {
    _CategoryId = CategoryId;
    _CategoryName = CategoryName;
    _Description = Description;
  }

  public int CategoryId {
    set { _CategoryId = value; }
    get { return _CategoryId; }
  }
  public string CategoryName {
    set { _CategoryName = value; }
    get { return _CategoryName; }
  }
  public string Description {
    set { _Description = value; }
    get { return _Description; }
  }
  public bool IsDelete {
    set { _IsDelete = value; }
    get { return _IsDelete; }
  }
}
