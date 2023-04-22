using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : Base_Ship_Component
{

    [SerializeField] private Sc_Bridge m_sc_Bridge;
    Bridge_Stats m_bridgeStats;
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

        m_sc_Base_Ship_Component = m_sc_Bridge;
        m_bridgeStats = new Bridge_Stats(m_sc_Bridge.ActionPoints);
        base.Init();
    }
}
