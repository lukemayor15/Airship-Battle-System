using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleButtonStateMachine : StateMachine
{
    State previousState;
    // Start is called before the first frame update
    void Start()
    {
        SetState(new BattleUIBattleWheelState(this));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void SetState(State state)
    {
        previousState = m_state;
        base.SetState(state);
    }
}
