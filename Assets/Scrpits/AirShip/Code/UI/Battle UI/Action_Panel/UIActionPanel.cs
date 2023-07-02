using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIActionPanel : BattleUIGroup
{

    public Button m_prefabButton;

    private void Start()
    {

    }
    //Move out to a greante a seprate class 
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
        UIGenerateAirshipWeapons.onUIGenerateAirshipGenerateWeapons += GenerateWeaponButtons;
        BattleUIActionStateEnterDelgate.onBattleUIActionStateEnter += EnabledUI;
        BattleUIActionStateExitDelgate.onBattleUIActionStateExit += DisableUI;
    }

    protected override void OnDisable()
    {
        UIGenerateAirshipWeapons.onUIGenerateAirshipGenerateWeapons -= GenerateWeaponButtons;
        EnterdAttackPanelStateDelgate.enterdAttackPanelState -= EnabledUI;
        BattleUIActionStateExitDelgate.onBattleUIActionStateExit -= DisableUI;
    }
}
