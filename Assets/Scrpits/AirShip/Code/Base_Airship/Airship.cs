using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Airship : MonoBehaviour
{
    //
    [SerializeField] private Sc_Airship m_sc_AirShip;
    //Compoments of the airship
    [SerializeField] private Hull m_hull;
    [SerializeField] private SideThrusters m_sideThrusters;
    [SerializeField] private Engine m_engine;
    [SerializeField] private Deck m_deck;
    [SerializeField] private Bridge m_bridge;
    [SerializeField] private List<Sc_WeaponTypes> m_Sc_weaponTypes;
    [SerializeField] private List<Weapon_Base> m_weaponTypesList = new List<Weapon_Base>();
    [SerializeField] private AirShipStats m_airship_Stats;
    [SerializeField] private GenerateAirShipSprite m_generateAirShipSprite;
    public List<Weapon_Base> WeaponTypesList { get => m_weaponTypesList; set => m_weaponTypesList = value; }
    public AirShipStats AirShipStats { get => m_airship_Stats; set => m_airship_Stats = value; }


    [SerializeField] public Button test_button;

    // Start is called before the first frame update
    void Start()
    {
        //Once the ship has been initalise communciate with the Ui Battle Manager to trigger the loading 
        //of the Ui elements
        Init();
        AirshipInitalisedDelgate.onAirshipInitalised?.Invoke(this);

    }

    private void Init()
    {

        m_airship_Stats = new AirShipStats(m_sc_AirShip.Manoeuvring, m_sc_AirShip.ActionPoints, m_sc_AirShip.Speed, m_sc_AirShip.Name, m_sc_AirShip.Health, m_sc_AirShip.Armor, m_sc_AirShip.HitChance);

        ////loop through the weapones and create them
        //Create the default actions for all ships, rethink this to better store the value and cost;
        //create the weapon and a battle_actions

        int IdCounter = 0;
        foreach (var weapon in m_Sc_weaponTypes)
        {
            IdCounter++;
            Weapon_Base createWeapon = null;
           switch(weapon.WeaponType)
           {
                case WeaponTypes.CANNON:
                    createWeapon = gameObject.AddComponent<Weapon_Cannon>();                   
                    break;
                case WeaponTypes.BURST_CANNON:
                    createWeapon = gameObject.AddComponent<Weapon_Burst_Cannon>();
                    break;
                case WeaponTypes.BALLISTA:
                    createWeapon = gameObject.AddComponent<Weapon_Ballista>();
                    break;
                case WeaponTypes.FLAMER:
                    createWeapon = gameObject.AddComponent<Weapon_Flamer>();
                    break;
                case WeaponTypes.HARPOON:
                    createWeapon = gameObject.AddComponent<Weapon_Harpoon>();
                    break;
                case WeaponTypes.MINE_TREBUCHET:
                    createWeapon = gameObject.AddComponent<Weapon_Mine_Trebuchet>();
                    break;
                case WeaponTypes.RAM:
                    createWeapon = gameObject.AddComponent<Weapon_Ram>();
                    break;
                case WeaponTypes.TORPEDO:
                    createWeapon = gameObject.AddComponent<Weapon_Torpedo>();
                    break;
                case WeaponTypes.WEATHER_CHANGER:
                    createWeapon = gameObject.AddComponent<Weapon_Weather_Changer>();
                    break;
            }

            createWeapon.Init(weapon, IdCounter);
            m_weaponTypesList.Add(createWeapon);

        }

        m_generateAirShipSprite.SetSprites(this);

    }

}
