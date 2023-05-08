using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI_Battle_Wheel : MonoBehaviour
{
    [SerializeField] private GameObject m_battleWheel;
    [SerializeField] private List<Button> m_actionsButton;
    public int m_Button_Padding;

    // Start is called before the first frame update
    void Start()
    {
        float boundSize = m_battleWheel.GetComponent<Renderer>().localBounds.size.x;
        Debug.Log(boundSize);
        //Place them
        m_actionsButton[0].gameObject.transform.position = Utility_Wheel_Icon_Placement.CalulateVectorForMaxY(boundSize, m_battleWheel.transform);
        m_actionsButton[1].gameObject.transform.position = Utility_Wheel_Icon_Placement.CalulateVectorForMaxXMaxY(boundSize, m_battleWheel.transform);
        m_actionsButton[2].gameObject.transform.position = Utility_Wheel_Icon_Placement.CalulateVectorForMaxX(boundSize, m_battleWheel.transform);
        m_actionsButton[3].gameObject.transform.position = Utility_Wheel_Icon_Placement.CalulateVectorForMaxXMinY(boundSize, m_battleWheel.transform);

        //m_placeGameObject.transform.localPosition = Utility_Wheel_Icon_Placement.CalulateVectorForMinXMaxY(boundSize, m_battleWheel.transform);
    }

    private void OnEnable()
    {
        //Listen if the attack buttons are select if so, stop these buttons being interactive
        Delgate_EnableAttackPanel.onEnableAttackPanel += DisableButtons;
    }

    private void OnDisable()
    {
        
    }

    private void DisableButtons()
    {
        foreach(Button button in m_actionsButton )
        {
            button.interactable = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

   
}
