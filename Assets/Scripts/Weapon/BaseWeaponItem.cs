using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeaponItem
{
    public float ItemWeight { get; private set; }
    public float ItemPrice { get; private set; }

    public List<PlayerActions> weaponActionList;

    public BaseWeaponItem(WeaponBaseData weaponBaseData)
    {
        ItemWeight = weaponBaseData.weightBase;
        ItemPrice = weaponBaseData.priceBase;

        weaponActionList = new List<PlayerActions>(weaponBaseData.weaponActionList);

        UpdateRealStats();
    }

    /// <summary>
    /// Method to update the current stat value. Use when you need to update
    /// one weapon/item atribute or stat. This method link all the stats to 
    /// update its real value.
    /// </summary>
    protected virtual void UpdateRealStats()
    {
        //TODO implement variable wheight and price methods
    }

    /// <summary>
    /// Override ToString to show class data when use ToString()
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        string message = "Item weight: " + ItemWeight + " Item price: " + ItemPrice;

        return message;
    }
}
