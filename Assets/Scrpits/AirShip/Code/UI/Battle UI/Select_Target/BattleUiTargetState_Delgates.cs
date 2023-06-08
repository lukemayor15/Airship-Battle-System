using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUITargetStateEnterDelgates
{
    public delegate void OnBattleUITargetStateEnter();
    static public OnBattleUITargetStateEnter onBattleUITargetStateEnter;
}

public class BattleUITargetStateExitDelgates
{
    public delegate void OnBattleUITargetStateExit();
    static public OnBattleUITargetStateExit onBattleUITargetStateExit;
}

public class BattleUITargetNextStateDelgates
{
    public delegate void OnBattleUITargetNextState();
    static public OnBattleUITargetNextState onBattleUITargetNextState;
}
