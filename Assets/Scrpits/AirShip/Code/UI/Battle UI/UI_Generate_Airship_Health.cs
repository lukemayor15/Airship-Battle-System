using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Generate_Airship_Health : MonoBehaviour
{
    public GameObject m_prefabHealth;
    public GameObject m_healthPanel;

    private void OnEnable()
    {
        UIGenerateAirshipStats.onUIGenerateAirshipStats += GenerateAirshipHealth;
    }
    private void OnDisable()
    {
        UIGenerateAirshipStats.onUIGenerateAirshipStats -= GenerateAirshipHealth;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateAirshipHealth(AirShip_Stats airship_Stats)
    {
        GameObject newbutton = Instantiate(m_prefabHealth);
        newbutton.gameObject.transform.SetParent(m_healthPanel.gameObject.transform);
    }

}
