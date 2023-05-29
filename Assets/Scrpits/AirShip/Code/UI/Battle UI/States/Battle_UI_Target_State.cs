using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_UI_Target_State : Battle_UI_State
{
    // Start is called before the first frame update
    public override void Start()
    {
        //Trigger Battle_ButtonActionState
        BattleUiTargetStateEnter_Delgates.onBattleUITargetStateEnter?.Invoke();
        Back_Button_Clicked.onBackButtonClicked += FirstCLicked;
        BattleUiTargetStateExit_Delgates.onBattleUITargetStateExit += Exit;
        BattleUiTargetNextState_Delgates.onBattleUITargetNextState += NextState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Battle_UI_Target_State(StateMachine StateMachine) : base(StateMachine)
    {

    }

    private void FirstCLicked()
    {
        Transition(new Battle_UI_Action_State(m_stateMachine));
    }

    private void NextState()
    {
        Transition(new Battle_UI_Battle_Wheel_State(m_stateMachine));
    }

    public override void Exit()
    {
        Back_Button_Clicked.onBackButtonClicked -= FirstCLicked;
        BattleUIActionNextState_Delgate.onBattleUIActionNextState -= Exit;
        BattleUiTargetNextState_Delgates.onBattleUITargetNextState -= NextState;
        BattleUIActionStateExit_Delgate.onBattleUIActionStatExit?.Invoke();
    }
}
