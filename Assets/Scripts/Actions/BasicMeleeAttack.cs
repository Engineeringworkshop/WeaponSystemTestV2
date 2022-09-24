using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerAction", menuName = "Data/Actions/BasicMeleeAttack")]
public class BasicMeleeAttack : PlayerActions
{
    public override void ExecutePlayerAction()
    {
        // Coger� los datos de los stats de arma
        Debug.Log("Basic melee attack: " + actionName);
    }
}
