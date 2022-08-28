using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "newWeaponBaseData", menuName = "Data/Weapons/Weapon base data")]
public class WeaponBaseData : ScriptableObject
{
    [Header("Base")]
    public float weightBase;
    public float priceBase;
}
