using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemySelectEnabled : BattleUIGroup
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
        BattleUITargetStateEnterDelgates.onBattleUITargetStateEnter += EnabledUI;
        BattleUITargetStateEnterDelgates.onBattleUITargetStateEnter += EnableInteractable;

        BattleUITargetStateExitDelgates.onBattleUITargetStateExit += DisableUI;
    }

    protected override void OnDisable()
    {
        BattleUITargetStateEnterDelgates.onBattleUITargetStateEnter -= EnabledUI;
        BattleUITargetStateExitDelgates.onBattleUITargetStateExit -= DisableUI;
    }


}
