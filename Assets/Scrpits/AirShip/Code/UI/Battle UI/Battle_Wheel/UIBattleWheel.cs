using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIBattleWheel : BattleUIGroup
{
    [SerializeField] private GameObject m_battleWheel;
    public int m_Button_Padding;


    // Start is called before the first frame update
    void Start()
    {
        float boundSize = m_battleWheel.GetComponent<Renderer>().localBounds.size.x;
        Debug.Log(boundSize);
        //Place them
        buttons[0].gameObject.transform.position = UtilityWheelIconPlacement.CalulateVectorForMaxY(boundSize, m_battleWheel.transform);
        buttons[1].gameObject.transform.position = UtilityWheelIconPlacement.CalulateVectorForMaxXMaxY(boundSize, m_battleWheel.transform);
        buttons[2].gameObject.transform.position = UtilityWheelIconPlacement.CalulateVectorForMaxX(boundSize, m_battleWheel.transform);
        buttons[3].gameObject.transform.position = UtilityWheelIconPlacement.CalulateVectorForMaxXMinY(boundSize, m_battleWheel.transform);

    }

    protected override void OnEnable()
    {
        ////Listen if the attack buttons are select if so, stop these buttons being interactive
        //ToAttackState_Delgate.ToAttackPanelState += DisableInteractable;
        ////If we ending the turn limit the player actions, disable the battle wheel,
        ////all next buttons should be disable and we should resort to the normal player state
        //Delgate_EndTurn.onEndTurn += DisableInteractable;

        ////On player turn reenabled the interactiong
        //PlayerTurn_Delgate.onPlayerTurn += EnableInteractable;

        OnBattleWheelStateEnterDelgate.onBattleWheelEnter += EnableInteractable;
        OnBattleWheelStateExitDelgate.onBattleWheelStateExit += DisableInteractable;

    }

    protected override void OnDisable()
    {
        OnBattleWheelStateEnterDelgate.onBattleWheelEnter -= EnableInteractable;
        OnBattleWheelStateExitDelgate.onBattleWheelStateExit -= DisableInteractable;

    }


    // Update is called once per frame
    void Update()
    {
        
    }

   
}
