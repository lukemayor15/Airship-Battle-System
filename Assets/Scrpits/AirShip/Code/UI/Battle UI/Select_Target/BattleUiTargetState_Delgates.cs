using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUiTargetStateEnter_Delgates
{
    public delegate void OnBattleUITargetStateEnter();
    static public OnBattleUITargetStateEnter onBattleUITargetStateEnter;
}

public class BattleUiTargetStateExit_Delgates
{
    public delegate void OnBattleUITargetStateExit();
    static public OnBattleUITargetStateExit onBattleUITargetStateExit;
}

public class BattleUiTargetNextState_Delgates
{
    public delegate void OnBattleUITargetNextState();
    static public OnBattleUITargetNextState onBattleUITargetNextState;
}
