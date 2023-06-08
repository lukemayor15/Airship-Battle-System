using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBattleWheelStateEnterDelgate
{
    public delegate void OnBattleWheelStateEnter();
    public static OnBattleWheelStateEnter onBattleWheelEnter;
}

public class OnBattleWheelStateExitDelgate
{
    public delegate void OnBattleWheelStateExit();
    public static OnBattleWheelStateExit onBattleWheelStateExit;
}

public class OnBattleWheelNextStateDelgate
{
    public delegate void OnBattleWheelNextState();
    public static OnBattleWheelNextState onBattleWheelNextState;
}
