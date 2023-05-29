using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButtonHandler : MonoBehaviour
{
    public void OnActionButtonClicked()
    {
        //WRONG UPDate at some point
        BattleUIActionNextState_Delgate.onBattleUIActionNextState?.Invoke();
    }
}
