using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponItem : BaseWeaponItem
{
    // Melee damage
    private float minMeleeDamageBase;
    private float maxMeleeDamageBase;
    public int minMeleeDamage;
    public int maxMeleeDamage;

    // Melee attack speed
    private float meleeAttackSpeedBase;
    public float meleeAttackSpeed;

    public MeleeWeaponItem(MeleeWeaponBaseData weaponBaseData) : base(weaponBaseData)
    {
        // Melee damage
        minMeleeDamageBase = CalculateRandomStat(weaponBaseData.minMinMeleeDamage, weaponBaseData.minMaxMeleeDamage);
        maxMeleeDamageBase = CalculateRandomStat(weaponBaseData.maxMinMeleeDamage, weaponBaseData.maxMaxMeleeDamage);

        // Melee attack speed
        meleeAttackSpeedBase = weaponBaseData.meleeAttackSpeed;

        UpdateRealStats();
    }

    /// <summary>
    /// Method to calculate random stat
    /// </summary>
    /// <param name="maxValue"></param>
    /// <param name="minValue"></param>
    /// <returns></returns>
    protected float CalculateRandomStat(float maxValue, float minValue)
    {
        return Random.Range(maxValue, minValue);
    }

    /// <summary>
    /// Method to update the current stat value. Use when you need to update
    /// one weapon/item atribute or stat. This method link all the stats to 
    /// update its real value.
    /// </summary>
    protected override void UpdateRealStats()
    {
        base.UpdateRealStats();

        // Melee damage
        minMeleeDamage = Mathf.RoundToInt(minMeleeDamageBase);
        maxMeleeDamage = Mathf.RoundToInt(maxMeleeDamageBase);

        // Melee attack speed
        meleeAttackSpeed = meleeAttackSpeedBase;
    }

    /// <summary>
    /// Override ToString to show class data when use ToString()
    /// </summary>
    /// <returns></returns>

    public override string ToString()
    {
        return base.ToString() + " | " + "Melee min damage: " + minMeleeDamage + " Melee max damage: " + maxMeleeDamage;
    }
}
