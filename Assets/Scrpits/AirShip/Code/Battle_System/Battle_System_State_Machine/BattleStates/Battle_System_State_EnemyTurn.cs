using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_System_State_EnemyTurn : Battle_System_State
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

    public Battle_System_State_EnemyTurn(StateMachine StateMachine) : base(StateMachine)
    {

    }

    public IEnumerator EndTurn()
    {
        yield return new WaitForSeconds(5);
        Transition(new Battle_System_State_PlayerTurn(m_stateMachine));
        yield return null;
    }
}
