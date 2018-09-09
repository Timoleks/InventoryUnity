using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour {


	public Transform itemsParent;

	Inventory inventory;

	InventorySlot[] slots;

	void Start()
	{
		inventory = Inventory.instance;

		inventory.onItemChangedCallback += UpdateUI;

		slots = itemsParent.GetComponentsInChildren<InventorySlot>();
	}

	void UpdateUI()
	{
		for(int i = 0; i < slots.Length;i++)
		{
			if(i < inventory.products.Count)
			{
				slots[i].AddItem(inventory.products[i]);
				
			}
		}
		//Debug.Log("ui update");
	}

}
