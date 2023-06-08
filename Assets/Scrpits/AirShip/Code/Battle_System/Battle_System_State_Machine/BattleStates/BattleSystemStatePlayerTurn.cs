using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystemStatePlayerTurn : BattleSystemState
{

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        EndTurnDelgate.onEndTurn += EndTurn;
        PlayerTurn_Delgate.onPlayerTurn?.Invoke();
    }

   

    public BattleSystemStatePlayerTurn(StateMachine stateMachine) : base(stateMachine)
    {

    }

    public void EndTurn()
    {
        
        Transition(new BattleSystemStateEnemyTurn(m_stateMachine));
    }

}
