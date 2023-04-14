using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPoints_Stat : Base_Stat
{
    [SerializeField] private int m_actionPoints;

    ActionPoints_Stat(int actionPoints)
    {
        m_actionPoints = actionPoints;
    }
}
