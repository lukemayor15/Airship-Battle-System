using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBattleSystem : MonoBehaviour
{
    // Start is called before the first frame update
    //public UI_Generate_Weapons_Buttons generate_Weapons_Buttons;
    //public UI_Generate_Airship_stats generate_Airship_Stats;
    //public UI_Generate_Airship_Health generate_Airship_Health;

    [SerializeField] private Canvas m_battleCanvas;

    private void Awake()
    {
        m_battleCanvas = GetComponent<Canvas>();
    }

    private void OnEnable()
    {
        AirshipInitalisedDelgate.onAirshipInitalised += InitailseAirshipUI;
    }
    private void OnDisable()
    {
        AirshipInitalisedDelgate.onAirshipInitalised -= InitailseAirshipUI;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This function takes in the player airship and updates the UI to use them stats
    void InitailseAirshipUI(Airship airship)
    {
        UIGenerateAirshipWeapons.onUIGenerateAirshipGenerateWeapons?.Invoke(airship.WeaponTypesList);
        UIGenerateAirshipStatsDelegate.onUIGenerateAirshipStats?.Invoke(airship.AirShipStats);
    }


}
