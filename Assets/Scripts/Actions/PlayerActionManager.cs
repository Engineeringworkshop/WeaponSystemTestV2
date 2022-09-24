using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// TODO Load and save player action setup from load save manager
public class PlayerActionManager : MonoBehaviour
{
    // Action shorcuts
    private PlayerActions f1Action;
    private PlayerActions f2Action;
    private PlayerActions f3Action;
    private PlayerActions f4Action;

    // Current action selected
    private PlayerActions primaryAction;
    private PlayerActions secondaryAction;

    // Referencte to testInventory
    [SerializeField] private TestInventory playerInventory;

    private void OnEnable()
    {
        // Weapon change event
        TestInventory.OnWeaponChange += ChangeWeapon;
    }

    private void OnDisable()
    {
        // Weapon change event
        TestInventory.OnWeaponChange -= ChangeWeapon;
    }

    public void OnPrimaryAction()
    {
        if (primaryAction != null)
        {
            primaryAction.ExecutePlayerAction();
        }
    }

    public void OnSecondaryAction()
    {
        if (secondaryAction != null)
        {
            secondaryAction.ExecutePlayerAction();
        }
    }

    private void ChangeWeapon()
    {
        var currWeapon = playerInventory.ItemGenerated;

        if (currWeapon is RangedWeaponItem)
        {
            primaryAction = currWeapon.weaponActionList[0];
            secondaryAction = currWeapon.weaponActionList[1];
        }
        else if(currWeapon is MeleeWeaponItem)
        {
            primaryAction = currWeapon.weaponActionList[0];
            secondaryAction = null;
        }
        //else if (currWeapon is BaseWeaponItem && !(currWeapon is MeleeWeaponItem) && !(currWeapon is RangedWeaponItem))
        //{
        //    primaryAction = null;
        //    secondaryAction = null;
        //}
        else
        {
            primaryAction = null;
            secondaryAction = null;
            Debug.LogWarning("Wrong item type");
        }
    }
}
