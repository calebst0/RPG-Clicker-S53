using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyWeapon : MonoBehaviour {

    public int weaponID;

    public void buyWeapon()
    {


        if (weaponID == 0)
        {
            Debug.Log("weapon id not set");
            return;
        }

        for(int i = 0; i < Shop.shop.weapon.Count; i++)
        {

            if(!Shop.shop.weapon[i].owned && Shop.shop.weapon[i].itemID == weaponID)
            {

                if(Shop.shop.leveling.checkSpend(Shop.shop.weapon[i].weaponPrice))
                { 
                    Shop.shop.weapon[i].owned = true;
                    Shop.shop.leveling.spendGold(Shop.shop.weapon[i].weaponPrice);
                }
                
            }
        }
    }
}
