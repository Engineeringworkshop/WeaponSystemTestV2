using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropGeneration : MonoBehaviour
{
    [Header("Weapon data")]
    
    [SerializeField] private List<ScriptableObject> weaponLists;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Select a random weapon list (Ranged, melee...)
            int weaponTypeIndex = Random.Range(0, weaponLists.Count);

            // Select a random weapon to generate
            var itemData = ((ItemList)weaponLists[weaponTypeIndex]).GetItem();

            Debug.Log("Item data: " + itemData);

            var itemGenerated = GenerateItem(itemData);

            Debug.Log(itemGenerated.ToString());
        }
    }

    private BaseWeaponItem GenerateItem(Object itemData)
    {
        //Debug.Log("Index: " + index);

        if (itemData is RangedWeaponBaseData)
        {
            Debug.Log("RangedWeaponBaseData");
            return new RangedWeaponItem((RangedWeaponBaseData)itemData);
        }
        else if (itemData is MeleeWeaponBaseData)
        {
            Debug.Log("MeleeWeaponBaseData");
            return new MeleeWeaponItem((MeleeWeaponBaseData)itemData);
        }
        else
        {
            Debug.LogWarning("Wrong item type");
        }

        return null;
    }

}
