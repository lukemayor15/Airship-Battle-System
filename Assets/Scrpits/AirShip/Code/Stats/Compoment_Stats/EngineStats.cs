using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineStats 
{
    ManoeurvingStat m_manoeurvingStat;
    SpeedStat  m_speedStat;

    public EngineStats(int speed, int manoeuvring)
    {
        m_manoeurvingStat = new ManoeurvingStat(manoeuvring);
        m_speedStat = new SpeedStat(speed);
    }
}
