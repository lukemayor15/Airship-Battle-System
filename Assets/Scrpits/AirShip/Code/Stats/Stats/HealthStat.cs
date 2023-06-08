using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStat : BaseStat
{
    [SerializeField] private int m_heath;

    public HealthStat(int health)
    {
        m_heath = health;
    }

    public int Heath { get => m_heath; set => m_heath = value; }
}
