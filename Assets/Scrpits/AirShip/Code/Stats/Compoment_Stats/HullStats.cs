using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HullStats 
{
    ManoeurvingStat m_manoeurvingStat;
    SpeedStat m_speedStat;

    public HullStats(int manoeurving, int speed)
    {
        m_manoeurvingStat = new ManoeurvingStat(manoeurving);
        m_speedStat = new SpeedStat(speed);
    }

}
