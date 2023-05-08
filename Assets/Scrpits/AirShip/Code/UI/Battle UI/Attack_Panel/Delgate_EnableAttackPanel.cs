using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Delgate that is used to enable the attack panel.
public class Delgate_EnableAttackPanel 
{
    public delegate void OnEnableAttackPanel();
    public static OnEnableAttackPanel onEnableAttackPanel;
}
