using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideThrusters : BaseShipComponent
{
    [SerializeField] private Sc_SideThrusters sc_SideThrusters;
    [SerializeField] private SideThrustersStats sideThrusters_Stats;
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Setups the base values of the sideThrusters from the scriptable object and call base setup
     protected override void Init()
    {
        m_scBaseShipComponent = sc_SideThrusters;
        sideThrusters_Stats = new SideThrustersStats(sc_SideThrusters.Manoeuvring);
        base.Init();
    }
}
