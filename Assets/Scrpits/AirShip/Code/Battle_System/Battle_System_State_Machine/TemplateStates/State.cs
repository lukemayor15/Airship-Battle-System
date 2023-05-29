using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected StateMachine m_stateMachine;
    //!Constructor
    /*!
       \param eventManger - What controls the states for getting/playing a event
    */
    public State(StateMachine Manager)
    {
        this.m_stateMachine = Manager;
    }

    //!Start
    /*!
       This is a function to be override by the child class.
        This decides what to do on the start of a state
    */
    public virtual void Start()
    {
        Debug.Log($"<color=yellow>Battle system state started state: {this}</color>");

    }
    //!Update
    /*!
       This is a function to be override by the child class. 
       It is currently not used and unlikely to be used in the furture
       The logic if we want to update the state
    */
    public virtual void Update()
    {

    }
    //!Exit
    /*!
       This is a function to be override by the child class. 
       It is currently not used and unlikely to be used in the furture
         The logic if we want to exit the state
    */
    public virtual void Exit()
    {
    }

    public virtual void Transition(State battleSystemState)
    {
        Exit();
        m_stateMachine.SetState(battleSystemState);
    }

}

