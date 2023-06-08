using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideThrustersStats 
{
    ManoeurvingStat m_manoeuvringStat;

    public SideThrustersStats(int manoeuvring)
    {
        m_manoeuvringStat = new ManoeurvingStat(manoeuvring);
    }
}
