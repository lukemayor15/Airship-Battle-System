using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The attack panel contains all possbile attacks a ship can do

public class UI_Attack_Panel : MonoBehaviour
{
    public GameObject m_AttackPanel;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void OnEnable()
    {
        Delgate_EnableAttackPanel.onEnableAttackPanel += Enable;
        ActionSelect.onActionSelected += disable;
    }

    private void Enable()
    {
        m_AttackPanel.SetActive(true);
    }
    private void disable()
    {
        m_AttackPanel.SetActive(false);
    }
    private void OnDisable()
    {
        Delgate_EnableAttackPanel.onEnableAttackPanel -= Enable;
    }
}
