using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Trigger enable the battle wheel on display everything
public class Battle_UI_Battle_Wheel_State : Battle_UI_State
{

    // Start is called before the first frame update
    public override void Start()
    {
        // we will have four states that are trigger here
        OnBattleWheelNextState_Delgate.onBattleWheelNextState += NextState;
        OnBattleWheelStateEnter_Delgate.onBattleWheelEnter?.Invoke();

        //Need to trigger an enable 
        //Use the state machine to set the other Ui elements defaulty false
        //and enabled based when the states are enterd and exited.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Battle_UI_Battle_Wheel_State(StateMachine StateMachine) : base(StateMachine)
    {

    }

    public override void Exit()
    {
        OnBattleWheelNextState_Delgate.onBattleWheelNextState -= NextState;

        OnBattleWheelStateExit_Delgate.onBattleWheelStateExit?.Invoke();
    }
    public void NextState()
    {
        Transition(new Battle_UI_Action_State(m_stateMachine));
    }
}
