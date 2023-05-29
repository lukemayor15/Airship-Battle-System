using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemySelectEnabled : Battle_UI_Group
{
    // Start is called before the first frame update

  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnEnable()
    {
        BattleUiTargetStateEnter_Delgates.onBattleUITargetStateEnter += EnabledUI;
        BattleUiTargetStateEnter_Delgates.onBattleUITargetStateEnter += EnableInteractable;

        BattleUiTargetStateExit_Delgates.onBattleUITargetStateExit += DisableUI;
    }

    protected override void OnDisable()
    {
        BattleUiTargetStateEnter_Delgates.onBattleUITargetStateEnter -= EnabledUI;
        BattleUiTargetStateExit_Delgates.onBattleUITargetStateExit -= DisableUI;
    }


}
