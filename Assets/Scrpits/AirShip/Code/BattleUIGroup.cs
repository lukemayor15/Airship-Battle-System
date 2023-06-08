using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This class is use to sturcture common functionality between classes that require the controling of buttons
public abstract class BattleUIGroup : MonoBehaviour
{
   [SerializeField] protected List<Button> buttons;
   [SerializeField] protected GameObject m_UIElement;


    protected virtual void OnEnable()
    {


    }

    protected virtual void OnDisable()
    {

    }
    protected void DisableInteractable()
    {
        if(buttons.Count > 0)
        {
            foreach (Button button in buttons)
            {
                button.interactable = false;
            }
        }
    }

    protected void EnableInteractable()
    {
        if (buttons.Count > 0)
        {
            foreach (Button button in buttons)
            {
                button.interactable = true;
            }
        }
    }

    protected void DisableUI()
    {
        if(m_UIElement.activeSelf)
        {
            m_UIElement.SetActive(false);
        }
    }

    protected void EnabledUI()
    {
        if (!m_UIElement.activeSelf)
        {
            m_UIElement.SetActive(true);
        }
        
    }



}
