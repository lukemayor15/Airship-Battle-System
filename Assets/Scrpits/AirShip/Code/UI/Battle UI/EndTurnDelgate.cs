using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Delgate that is used to enable the attack panel.
public class EndTurnDelgate
{
    public delegate void OnEndTurn();
    public static OnEndTurn onEndTurn;
}
