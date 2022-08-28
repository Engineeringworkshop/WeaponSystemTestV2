using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newRangedWeaponBaseData", menuName = "Data/Weapons/Range weapon base data")]
public class RangedWeaponBaseData : MeleeWeaponBaseData
{
    [Header("Range")]
    //public bool isRangedWeapon;
    //public WeaponReloadModes weaponReloadMode;

    public float minMinRangeDamage;
    public float minMaxRangeDamage;
    public float maxMinRangeDamage;
    public float maxMaxRangeDamage;
    public float rangeAttackSpeed;

    public int maxClipBulletCapacity;
}
