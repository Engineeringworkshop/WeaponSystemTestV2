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

    // Action list
    [SerializeField] private List<PlayerActions> actionList = new List<PlayerActions>();

    // Referencte to testInventory
    [SerializeField] private TestInventory playerInventory;

    private void Start()
    {
        // Fill action list
        actionList.Add(new BasicRangedAttack());
        actionList.Add(new BasicMeleeAttack());

        primaryAction = actionList[0];
        secondaryAction = actionList[1];
    }

    public void OnPrimaryAction()
    {
        primaryAction.ExecutePlayerAction();
    }

    public void OnSecondaryAction()
    {
        secondaryAction.ExecutePlayerAction();
    }
}
