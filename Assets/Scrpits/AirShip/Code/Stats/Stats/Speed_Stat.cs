using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Stat : Base_Stat
{
    [SerializeField] private int m_speed;

    public Speed_Stat(int speed)
    {
        m_speed = speed;
    }
}
