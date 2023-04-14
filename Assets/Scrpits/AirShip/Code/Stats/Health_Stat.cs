using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Stat : Base_Stat
{
    [SerializeField] private int m_heath;

    public Health_Stat(int health)
    {
        m_heath = health;
    }

    public int Heath { get => m_heath; set => m_heath = value; }
}
