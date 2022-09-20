using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerAction", menuName = "Data/Actions/BasicMeleeAttack")]
public class PlayerActions : ScriptableObject
{
    public string actionName;

    public virtual void ExecutePlayerAction()
    {

    }
}
