using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Trigger enable the battle wheel on display everything
public class BattleUIBattleWheelState : BattleUIState
{

    // Start is called before the first frame update
    public override void Start()
    {
        // we will have four states that are trigger here
        OnBattleWheelNextStateDelgate.onBattleWheelNextState += NextState;
        OnBattleWheelStateEnterDelgate.onBattleWheelEnter?.Invoke();

        //Need to trigger an enable 
        //Use the state machine to set the other Ui elements defaulty false
        //and enabled based when the states are enterd and exited.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public BattleUIBattleWheelState(StateMachine StateMachine) : base(StateMachine)
    {

    }

    public override void Exit()
    {
        OnBattleWheelNextStateDelgate.onBattleWheelNextState -= NextState;

        OnBattleWheelStateExitDelgate.onBattleWheelStateExit?.Invoke();
    }
    public void NextState()
    {
        Transition(new BattleUIActionState(m_stateMachine));
    }
}
