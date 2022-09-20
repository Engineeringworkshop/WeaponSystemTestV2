using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerAction", menuName = "Data/Actions/BasicRangedAttack")]
public class BasicRangedAttack : PlayerActions
{
    public override void ExecutePlayerAction()
    {
        Debug.Log("Basic ranged attack: " + actionName);
    }
}
