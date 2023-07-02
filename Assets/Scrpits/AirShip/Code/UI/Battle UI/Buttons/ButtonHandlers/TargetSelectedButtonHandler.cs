using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSelectedButtonHandler : MonoBehaviour
{
    public void OnTargetSelectedButtonClicked()
    {
        BattleUITargetNextStateDelgates.onBattleUITargetNextState?.Invoke();
    }
}
