using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSlot : MonoBehaviour {

	 public Product item;

	 public Button buyButton;
	 public Sprite disableButtonSprite;
	 public Sprite activeButtonSprite;

	 //public GameObject warningObj;

	 public Text itemPriceText;

	 Inventory inventory;

	 void Start()
	 {
		 inventory = Inventory.instance;
		 itemPriceText.text = item.Price.ToString();
	 }


	 // IEnumerator warningText()
	 // {
		//  warningObj.SetActive(true);
		//  yield return new WaitForSeconds(1.2f);
		//  warningObj.SetActive(false);
	 // }

	 public void BuyItem()
	 {
		if(inventory.products.Count <= inventory.space)
		{
			 if(inventory.user.Balance >= item.Price)
			 {
				 inventory.user.ReduceBalance(item.Price);
				 inventory.Add(item);

			 }

		}
		// if(inventory.products.Count >= inventory.space)
		// {
		// 	StartCoroutine(warningText());
		// }

	 }

	 void Update()
	 {
		 if(inventory.user.Balance < item.Price)
		 {
			 buyButton.interactable = false;
			 if(!buyButton.interactable)
			 {
				 buyButton.GetComponent<Image>().sprite = disableButtonSprite;
			 }
		 }
		 if(inventory.user.Balance >= item.Price)
		 {
			 buyButton.interactable = true;
			 if(buyButton.interactable)
			 {
				 buyButton.GetComponent<Image>().sprite = activeButtonSprite;
			 }
		 }
	 }

}
