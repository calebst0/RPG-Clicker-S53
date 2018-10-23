using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyWeapon : MonoBehaviour {

    public int weaponID;
    public LevelingScript gold;

    public void buyWeapon()
    {
        if( weaponID == 0)
        {
            Debug.Log("weapon id not set");
            return;
        }

        for(int i = 0; i < Shop.shop.weapon.Count; i++)
        {

            if(!Shop.shop.weapon[i].owned && Shop.shop.weapon[i].weaponID == weaponID)
            {
                if(gold.checkSpend(Shop.shop.weapon[i].weaponPrice))
                {
                    Shop.shop.weapon[i].owned = true;
                    gold.spendGold(Shop.shop.weapon[i].weaponPrice);
                }
            }
        }
    }
}
