using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_Button_State_Machine : StateMachine
{
    State previousState;
    // Start is called before the first frame update
    void Start()
    {
        SetState(new Battle_UI_Battle_Wheel_State(this));
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
