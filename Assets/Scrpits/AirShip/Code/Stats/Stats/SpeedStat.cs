using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedStat : BaseStat
{
    [SerializeField] private int m_speed;

    public SpeedStat(int speed)
    {
        m_speed = speed;
    }
}
