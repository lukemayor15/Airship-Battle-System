using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUITargetState : BattleUIState
{
    // Start is called before the first frame update
    public override void Start()
    {
        //Trigger Battle_ButtonActionState
        BattleUITargetStateEnterDelgates.onBattleUITargetStateEnter?.Invoke();
        BackButtonClicked.onBackButtonClicked += FirstCLicked;
        BattleUITargetNextStateDelgates.onBattleUITargetNextState += NextState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public BattleUITargetState(StateMachine StateMachine) : base(StateMachine)
    {

    }

    private void FirstCLicked()
    {
        Transition(new BattleUIActionState(m_stateMachine));
    }

    private void NextState()
    {
        Transition(new BattleUIBattleWheelState(m_stateMachine));
        BattleUIActionStateExitDelgate.onBattleUIActionStateExit?.Invoke();

    }

    public override void Exit()
    {
        BackButtonClicked.onBackButtonClicked -= FirstCLicked;
        BattleUITargetNextStateDelgates.onBattleUITargetNextState -= NextState;
        BattleUITargetStateExitDelgates.onBattleUITargetStateExit?.Invoke();
    }
}
