using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : Base_Ship_Component
{

    [SerializeField] private Sc_Engine m_sc_Engine;
    Engine_Stats m_EningeStats;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    //Setups the base values of the Engine from the scriptable object and call base setup
    protected override void Init()
    {
        m_sc_Base_Ship_Component = m_sc_Engine;
        m_EningeStats = new Engine_Stats(m_sc_Engine.Speed, m_sc_Engine.Manoeuvring);
        base.Init();
    }
}
