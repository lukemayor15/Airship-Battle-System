using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Delgate that is used to enable the attack panel.
public class Delgate_EndTurn
{
    public delegate void OnEndTurn();
    public static OnEndTurn onEndTurn;
}
