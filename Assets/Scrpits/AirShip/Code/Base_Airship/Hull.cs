using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hull : Base_Ship_Component
{
    [SerializeField] private Sc_Hull m_sc_Hull;
    // Start is called before the first frame update
    Hull_Stats Hull_Stats;
 

    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Setups the base values of the Hull from the scriptable object and call base setup
    protected override void Init()
    {
        m_sc_Base_Ship_Component = m_sc_Hull;
        Hull_Stats = new Hull_Stats(m_sc_Hull.Manoeuvring, m_sc_Hull.Speed);
        base.Init();

    }
}
