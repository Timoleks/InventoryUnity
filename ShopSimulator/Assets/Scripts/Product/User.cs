using UnityEngine;
using System;



public class User  {

	public double Balance {get;set;}


	public User(int balance)
	{
		Balance = balance;
	}

	public void ReduceBalance(double price)
	{
		Balance -= price;
	}
}
