using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contains the list of items. Can be used for simplify item generation
/// </summary>
[CreateAssetMenu(fileName = "newItemList", menuName = "Data/Items/Items list")]
public class ItemList : ScriptableObject
{
    [Header("List for items")]
    public List<Object> itemsList;

    public Object GetItem()
    {
        return itemsList[Random.Range(0, itemsList.Count)];
    }
}
