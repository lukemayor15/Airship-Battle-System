using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurnButtonHandler : MonoBehaviour
{
    public void OnEndTurnButtonClicked()
    {
        EndTurnDelgate.onEndTurn?.Invoke();
    }

}
