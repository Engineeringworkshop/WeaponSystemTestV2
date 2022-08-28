using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newMeleeWeaponBaseData", menuName = "Data/Weapons/Melee weapon base data")]
public class MeleeWeaponBaseData : WeaponBaseData
{
    [Header("Melee")]
    public float minMinMeleeDamage;
    public float minMaxMeleeDamage;
    public float maxMinMeleeDamage;
    public float maxMaxMeleeDamage;
    public float meleeAttackSpeed;
}
