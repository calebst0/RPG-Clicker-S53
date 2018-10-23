using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public static Shop shop;
    public List<Weapon> weapon = new List<Weapon>();

    public GameObject itemPrefab;
    public Transform tGrid;

	// Use this for initialization
	void Start ()
    {
        shop = this;

        FillShop();
	}
	
	void FillShop()
    {
        for(int i = 0; i < weapon.Count; i++)
        {
            GameObject temp = Instantiate(itemPrefab, tGrid);

            ItemHolder holderScript = temp.GetComponent<ItemHolder>();

            holderScript.itemName.text = weapon[i].weaponName;
            holderScript.itemPrice.text = weapon[i].weaponPrice.ToString();
            holderScript.itemImage.sprite = weapon[i].weaponSprite;

            holderScript.buyButton.GetComponent<BuyWeapon>().weaponID = weapon[i].weaponID;
        }
    }
	
}
