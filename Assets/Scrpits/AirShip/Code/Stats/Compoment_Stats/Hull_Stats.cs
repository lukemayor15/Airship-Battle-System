using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hull_Stats 
{
    Manoeurving_stat m_manoeurvingStat;
    Speed_Stat m_speedStat;

    public Hull_Stats(int manoeurving, int speed)
    {
        m_manoeurvingStat = new Manoeurving_stat(manoeurving);
        m_speedStat = new Speed_Stat(speed);
    }

}
