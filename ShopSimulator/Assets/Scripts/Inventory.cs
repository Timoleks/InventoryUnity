using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

  #region Singleton

  public static Inventory instance;

  void Awake()
  {
    instance = this;
  }

  #endregion


  public int  userBalanceValue = 1000;

  int moneyMod = 200;

  public int space = 2;

	public Text balanceValueText;


	public List<Product> products = new List<Product>();

  public delegate void OnItemChanged();
  public OnItemChanged onItemChangedCallback;



	public User user;

	void Start()
	{
		user = new User(userBalanceValue);
		balanceValueText.text = user.Balance.ToString();


	}

  void Update()
  {
    balanceValueText.text = user.Balance.ToString();


  }


  public void Add(Product item)
  {
    

      products.Add(item);

      if(onItemChangedCallback != null)
        onItemChangedCallback.Invoke();




  }

  public void AddMoney()
  {
    user.Balance += moneyMod;
  }

}
