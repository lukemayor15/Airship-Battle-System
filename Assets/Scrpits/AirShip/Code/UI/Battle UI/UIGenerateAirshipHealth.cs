using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGenerateAirshipHealth : MonoBehaviour
{
    public GameObject m_prefabHealth;
    public GameObject m_healthPanel;

    private void OnEnable()
    {
        UIGenerateAirshipStatsDelegate.onUIGenerateAirshipStats += GenerateAirshipHealth;
    }
    private void OnDisable()
    {
        UIGenerateAirshipStatsDelegate.onUIGenerateAirshipStats -= GenerateAirshipHealth;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateAirshipHealth(AirShipStats airship_Stats)
    {
        GameObject newbutton = Instantiate(m_prefabHealth);
        newbutton.gameObject.transform.SetParent(m_healthPanel.gameObject.transform);
    }

}
