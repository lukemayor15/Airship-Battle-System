using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn_Button_Handler : MonoBehaviour
{
    public void OnEndTurnButtonClicked()
    {
        Delgate_EndTurn.onEndTurn?.Invoke();
    }

}
