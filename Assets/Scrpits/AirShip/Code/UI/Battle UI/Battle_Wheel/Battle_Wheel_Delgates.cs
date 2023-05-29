using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBattleWheelStateEnter_Delgate
{
    public delegate void OnBattleWheelStateEnter();
    public static OnBattleWheelStateEnter onBattleWheelEnter;
}

public class OnBattleWheelStateExit_Delgate
{
    public delegate void OnBattleWheelStateExit();
    public static OnBattleWheelStateExit onBattleWheelStateExit;
}

public class OnBattleWheelNextState_Delgate
{
    public delegate void OnBattleWheelNextState();
    public static OnBattleWheelNextState onBattleWheelNextState;
}
