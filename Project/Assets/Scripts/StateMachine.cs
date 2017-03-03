using UnityEngine;
using System.Collections;

public class StateMachine {
    public State currentState;
    public Enemy owner;

    public StateMachine (Enemy entity) {
        owner = entity;
    }

    public void Execute () {
        if (currentState != null)
            currentState.Update(owner);
    }

    public void changeState (State newState) {
        if(currentState != null)
            currentState.Exit(owner);
        currentState = newState;
        currentState.Enter(owner);
    }

    public void setState (State newState) {
        currentState = newState;
    }

    public State getState () {
        return currentState;
    }
}

