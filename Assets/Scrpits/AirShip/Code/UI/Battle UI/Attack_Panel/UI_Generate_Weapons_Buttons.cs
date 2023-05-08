using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI_Generate_Weapons_Buttons : MonoBehaviour
{

    public Button m_prefabButton;
    public List<Button> m_weaponButton =  new List<Button>();
    public GameObject m_weaponesPanel;

    private void Start()
    {
        UIGenerateAirshipWeapons.onUIGenerateAirshipGenerateWeapons += GenerateWeaponButtons;
    }
    //Generate a list of weapons and try and do an attack,
    public void GenerateWeaponButtons(List<Weapon_Base> weapons)
    {
        foreach(Weapon_Base weapon in weapons)
        {
            Button newbutton = Instantiate(m_prefabButton);
            newbutton.gameObject.transform.SetParent(m_weaponesPanel.gameObject.transform);
            //This will change, this will set up the target selector, then trigger the TryDoAttack.
            //Note more logic will be in place in try, will consdier range and other aspects.
            newbutton.onClick.AddListener(weapon.TryDoAttack);
            m_weaponButton.Add(newbutton);
        }

        //SEt up the on click here
    }

    
}
