using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitChance_Stat : Base_Stat
{
    [SerializeField] private int m_hitChance;

    public HitChance_Stat(int hitChance)
    {
        m_hitChance = hitChance;
    }
}
