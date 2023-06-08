using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitChanceStat : BaseStat
{
    [SerializeField] private int m_hitChance;

    public HitChanceStat(int hitChance)
    {
        m_hitChance = hitChance;
    }
}
