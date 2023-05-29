using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Button_Handler : MonoBehaviour
{
    public void OnAttackButtonClicked()
    {
        OnBattleWheelNextState_Delgate.onBattleWheelNextState?.Invoke();
    }
}
