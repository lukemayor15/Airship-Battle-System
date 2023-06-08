using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystemStateEnemyTurn : BattleSystemState
{
    // Start is called before the first frame update
    public override void Start()
    {
        m_stateMachine.StartCoroutine(EndTurn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public BattleSystemStateEnemyTurn(StateMachine StateMachine) : base(StateMachine)
    {

    }

    public IEnumerator EndTurn()
    {
        yield return new WaitForSeconds(5);
        Transition(new BattleSystemStatePlayerTurn(m_stateMachine));
        yield return null;
    }
}
