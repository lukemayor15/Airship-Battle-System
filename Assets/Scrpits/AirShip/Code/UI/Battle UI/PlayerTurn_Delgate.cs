using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn_Delgate 
{
    public delegate void  OnPlayerTurn();
    public static OnPlayerTurn onPlayerTurn;
}
