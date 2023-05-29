using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_System_State_Machine : StateMachine
{
    /// \brief EventStateMachine asbtract class.
    /// 
    /// This is an abstract class that is used to manage the states
    /// 
    //!SetState
    /*!
       This is used to Set the state 
        param state - This is the state we are setting it to.
    */
    private void Start()
    {
        SetState(new Battle_System_State_PlayerTurn(this));
    }

}
