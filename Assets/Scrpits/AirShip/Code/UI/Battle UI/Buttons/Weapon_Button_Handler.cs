using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Button_Handler : MonoBehaviour
{
    public void OnWeaponButtonClicked()
    {
        ActionSelect.onActionSelected?.Invoke();
    }
}
