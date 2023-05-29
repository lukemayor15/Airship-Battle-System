using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class StateMachine : MonoBehaviour
{
    /// \brief EventMangerStateMachine asbtract class.
    /// 
    /// This is an abstract class that is used to mange the states
    /// 
    ///
    protected State m_state;
    //!SetState
    /*!
       This is used to Set the state 
        param state - This is the state we are setting it to.
    */
    public virtual void SetState(State state)
    {
        m_state = state;
        m_state.Start();
    }
  
    //!GetState
    /*!
       Gets the current state that we are in, this is primarily used for debugging/logging
    */
    public State GetState()
    {
        return m_state;
    }
}
