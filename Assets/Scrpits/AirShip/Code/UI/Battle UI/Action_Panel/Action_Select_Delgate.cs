using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handles the logic when an action have been select, this is triggerd when an attacl button is pressed and enabled the selecting of targetable objects.
public class BattleUIActionStateEnter_Delgate
{

    public delegate void OnBattleUIActionStateEnter();
    public static OnBattleUIActionStateEnter onBattleUIActionStateEnter;

}

public class BattleUIActionStateExit_Delgate
{

    public delegate void OnBattleUIActionStatexit();
    public static OnBattleUIActionStatexit onBattleUIActionStatExit;

}

public class BattleUIActionNextState_Delgate
{

    public delegate void OnBattleUIActionNextState();
    public static OnBattleUIActionNextState onBattleUIActionNextState;

}


