using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPointsStat : BaseStat
{
    [SerializeField] private int m_actionPoints;

    public ActionPointsStat(int actionPoints)
    {
        m_actionPoints = actionPoints;
    }
}
