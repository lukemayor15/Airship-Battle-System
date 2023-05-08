using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine;



public class UI_Controller : MonoBehaviour
{
    private Input_Battle_Controls m_battleControls;

    private void Awake()
    {
        m_battleControls = new Input_Battle_Controls();
    }

    private void OnEnable()
    {
        m_battleControls.Battle_Controls.Move.performed += DoMove;
        m_battleControls.Battle_Controls.Move.Enable();
    }

    private void OnDisable()
    {
        m_battleControls.Battle_Controls.Move.Disable();
    }

    private void DoMove(InputAction.CallbackContext obj)
    {
        Debug.Log("Move");
    }

}

