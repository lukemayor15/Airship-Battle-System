using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideThrusters_Stats 
{
    Manoeurving_stat m_manoeuvringStat;

    public SideThrusters_Stats(int manoeuvring)
    {
        m_manoeuvringStat = new Manoeurving_stat(manoeuvring);
    }
}
