using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGenerationTest : MonoBehaviour
{
    public BaseWeaponItem BaseWeaponItem { get; private set; }
    public MeleeWeaponItem MeleeWeaponItem { get; private set; }
    public RangedWeaponItem RangedWeaponItem { get; private set; }

    // Basic generation
    [SerializeField] private WeaponBaseData weaponBaseData;
    [SerializeField] private MeleeWeaponBaseData meleeWeaponBaseData;
    [SerializeField] private RangedWeaponBaseData rangedWeaponBaseData;

    // Multi type generation
    [SerializeField] private WeaponBaseData[] generationList;
    
    private BaseWeaponItem currentGeneratedItem;

    void Start()
    {
        // Basic generation
        BaseWeaponItem = new BaseWeaponItem(weaponBaseData);
        MeleeWeaponItem = new MeleeWeaponItem(meleeWeaponBaseData);
        RangedWeaponItem = new RangedWeaponItem(rangedWeaponBaseData);

        // Multi type generation
    }


    void Update()
    {
        // Basic generation
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log(BaseWeaponItem.ToString());
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log(MeleeWeaponItem.ToString());
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(RangedWeaponItem.ToString());
        }
        // Multi type generation
        else if (Input.GetKeyDown(KeyCode.G))
        {
            currentGeneratedItem = GenerateRandomItem();

            Debug.Log(currentGeneratedItem.ToString());
        }
    }

    private BaseWeaponItem GenerateRandomItem()
    {
        var index = Random.Range(0, generationList.Length);
      
        //Debug.Log("Index: " + index);

        if (generationList[index] is RangedWeaponBaseData)
        {
            print("RangedWeaponBaseData");
            return new RangedWeaponItem((RangedWeaponBaseData)generationList[index]);
        }
        else if (generationList[index] is MeleeWeaponBaseData)
        {
            print("MeleeWeaponBaseData");
            return new MeleeWeaponItem((MeleeWeaponBaseData)generationList[index]);
        }
        else if (generationList[index] is WeaponBaseData)
        {
            print("WeaponBaseData");
            return new BaseWeaponItem(generationList[index]);
        }

        return null;
    }
}
