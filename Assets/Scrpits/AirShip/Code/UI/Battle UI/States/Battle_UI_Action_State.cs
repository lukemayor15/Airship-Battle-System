using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enable the Attack panel
public class Battle_UI_Action_State : Battle_UI_State
{
    // Start is called before the first frame update
    public override void Start()
    {
        //Trigger Battle_ButtonActionState
        BattleUIActionNextState_Delgate.onBattleUIActionNextState += NextState;
        BattleUIActionStateEnter_Delgate.onBattleUIActionStateEnter?.Invoke();
        Back_Button_Clicked.onBackButtonClicked += FirstCLicked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Battle_UI_Action_State(StateMachine StateMachine) : base(StateMachine)
    {

    }

    private void FirstCLicked()
    {
        Transition(new Battle_UI_Battle_Wheel_State(m_stateMachine));
    }

    public override void Exit()
    {
        BattleUIActionNextState_Delgate.onBattleUIActionNextState -= NextState;
        Back_Button_Clicked.onBackButtonClicked -= FirstCLicked;
        BattleUIActionStateExit_Delgate.onBattleUIActionStatExit?.Invoke();
       
    }

    public void NextState()
    {
        Transition(new Battle_UI_Target_State(m_stateMachine));
    }
}


