using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_System_State_PlayerTurn : Battle_System_State
{

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        Delgate_EndTurn.onEndTurn += EndTurn;
        PlayerTurn_Delgate.onPlayerTurn?.Invoke();
    }

   

    public Battle_System_State_PlayerTurn(StateMachine stateMachine) : base(stateMachine)
    {

    }

    public void EndTurn()
    {
        
        Transition(new Battle_System_State_EnemyTurn(m_stateMachine));
    }

}
