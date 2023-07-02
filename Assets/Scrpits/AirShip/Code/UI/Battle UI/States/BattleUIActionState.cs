using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enable the Attack panel
public class BattleUIActionState : BattleUIState
{
    // Start is called before the first frame update
    public override void Start()
    {
        //Trigger Battle_ButtonActionState
        BattleUIActionNextStateDelgate.onBattleUIActionNextState += NextState;
        BattleUIActionStateEnterDelgate.onBattleUIActionStateEnter?.Invoke();
        BackButtonClicked.onBackButtonClicked += FirstCLicked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public BattleUIActionState(StateMachine StateMachine) : base(StateMachine)
    {

    }

    private void FirstCLicked()
    {
        BattleUIActionStateExitDelgate.onBattleUIActionStateExit?.Invoke();
        Transition(new BattleUIBattleWheelState(m_stateMachine));
    }

    public override void Exit()
    {
        BattleUIActionNextStateDelgate.onBattleUIActionNextState -= NextState;
        BackButtonClicked.onBackButtonClicked -= FirstCLicked;
       
    }

    public void NextState()
    {
        Transition(new BattleUITargetState(m_stateMachine));
    }
}


