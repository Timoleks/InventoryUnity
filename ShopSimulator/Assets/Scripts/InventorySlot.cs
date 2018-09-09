using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {

	Product item;

	public Image icon;


 public void AddItem(Product newItem)
 {
	 this.item = newItem;

	 icon.sprite = item.icon;
	 icon.enabled = true;

 }

}
