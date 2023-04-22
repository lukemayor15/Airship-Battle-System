using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor_Stat : Base_Stat
{
    [SerializeField] private int m_armor;

    public Armor_Stat(int armor)
    {
        m_armor = armor;
    }

}
