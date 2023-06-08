using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIActionPanel : BattleUIGroup
{

    public Button m_prefabButton;

    private void Start()
    {
        UIGenerateAirshipWeapons.onUIGenerateAirshipGenerateWeapons += GenerateWeaponButtons;

    }
    //Generate a list of weapons and try and do an attack,
    private void GenerateWeaponButtons(List<Weapon_Base> weapons)
    {
        foreach(Weapon_Base weapon in weapons)
        {
            Button newbutton = Instantiate(m_prefabButton);
            newbutton.gameObject.transform.SetParent(m_UIElement.gameObject.transform);
            //This will change, this will set up the target selector, then trigger the TryDoAttack.
            //Note more logic will be in place in try, will consdier range and other aspects.
            newbutton.onClick.AddListener(weapon.TryDoAttack);
            buttons.Add(newbutton);
        }

        //SEt up the on click here
    }

    protected override void OnEnable()
    {
        BattleUIActionStateEnterDelgate.onBattleUIActionStateEnter += EnabledUI;
        BattleUIActionStateExitDelgate.onBattleUIActionStatExit += DisableUI;
    }

    protected override void OnDisable()
    {
        EnterdAttackPanelStateDelgate.enterdAttackPanelState -= EnabledUI;
        BattleUIActionStateExitDelgate.onBattleUIActionStatExit -= DisableUI;
    }
}
