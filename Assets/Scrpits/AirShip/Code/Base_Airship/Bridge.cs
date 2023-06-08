using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : BaseShipComponent
{

    [SerializeField] private Sc_Bridge m_sc_Bridge;
    BridgeStats m_bridgeStats;
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Setups the base values of the Bridge from the scriptable object and call base setup
    protected override void Init()
    {

        m_scBaseShipComponent = m_sc_Bridge;
        m_bridgeStats = new BridgeStats(m_sc_Bridge.ActionPoints);
        base.Init();
    }
}
