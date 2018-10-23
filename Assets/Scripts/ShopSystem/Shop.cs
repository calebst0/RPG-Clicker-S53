using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public static Shop shop;
    public List<Weapon> weapon = new List<Weapon>();

    public GameObject itemPrefab;
    public Transform tGrid;
    private List<GameObject> holderList = new List<GameObject>();

    public LevelingScript leveling;

    // Use this for initialization
    void Start ()
    {
        shop = this;

        FillShop();

        leveling = FindObjectOfType<LevelingScript>();
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

            holderScript.buyButton.GetComponent<BuyWeapon>().weaponID = weapon[i].itemID;

            holderList.Add(temp);
        }
    }
	
    void UpdateShop(int weaponID)
    {
        for(int i = 0; i < holderList.Count; i++)
        {
            ItemHolder holderScript = holderList[i].GetComponent<ItemHolder>();

            if(weapon[i].itemID == weaponID)
            {

            }
        }
    }

}
