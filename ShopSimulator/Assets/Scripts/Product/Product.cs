using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New item", menuName = "Shop/item")]
public class Product : ScriptableObject  {

	new public string name = "Name";
	public double Price;
	public Sprite icon = null;


}
