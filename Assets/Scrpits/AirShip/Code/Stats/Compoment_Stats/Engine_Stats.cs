using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine_Stats 
{
    Manoeurving_stat m_manoeurvingStat;
    Speed_Stat  m_speedStat;

    public Engine_Stats(int speed, int manoeuvring)
    {
        m_manoeurvingStat = new Manoeurving_stat(manoeuvring);
        m_speedStat = new Speed_Stat(speed);
    }
}
