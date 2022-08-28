using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponReloadModes
{
    None,
    Clip,
    Pump,
}
public class RangedWeaponItem : MeleeWeaponItem
{
    // Range damage
    private float minRangeDamageBase;
    private float maxRangeDamageBase;
    public int minRangeDamage;
    public int maxRangeDamage;

    // Range attack speed
    private float rangeAttackSpeedBase;
    public float rangeAttackSpeed;

    public RangedWeaponItem(RangedWeaponBaseData weaponBaseData) : base(weaponBaseData)
    {
        // Range damage
        minRangeDamageBase = CalculateRandomStat(weaponBaseData.minMinRangeDamage, weaponBaseData.minMaxRangeDamage);
        maxRangeDamageBase = CalculateRandomStat(weaponBaseData.maxMinRangeDamage, weaponBaseData.maxMaxRangeDamage);

        // Range attack speed
        rangeAttackSpeedBase = weaponBaseData.rangeAttackSpeed;

        UpdateRealStats();
    }

    /// <summary>
    /// Method to update the current stat value. Use when you need to update
    /// one weapon/item atribute or stat. This method link all the stats to 
    /// update its real value.
    /// </summary>
    protected override void UpdateRealStats()
    {
        base.UpdateRealStats();

        // Ranged damage
        minRangeDamage = Mathf.RoundToInt(minRangeDamageBase);
        maxRangeDamage = Mathf.RoundToInt(maxRangeDamageBase);

        // Ranged attack speed
        rangeAttackSpeed = rangeAttackSpeedBase;
    }

    /// <summary>
    /// Override ToString to show class data when use ToString()
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return base.ToString() + " | " + "Ranged min damage: " + minRangeDamage + " Ranged max damage: " + maxRangeDamage;
    }
}
