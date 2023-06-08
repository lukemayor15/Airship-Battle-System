using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButtonHandler : MonoBehaviour
{
    public void OnAttackButtonClicked()
    {
        OnBattleWheelNextStateDelgate.onBattleWheelNextState?.Invoke();
    }
}
