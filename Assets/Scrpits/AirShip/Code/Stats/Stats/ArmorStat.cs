using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorStat : BaseStat
{
    [SerializeField] private int m_armor;

    public ArmorStat(int armor)
    {
        m_armor = armor;
    }

}
