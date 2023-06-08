using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDistanceStat : BaseStat
{
    [SerializeField] private int m_MoveDistance;

    MoveDistanceStat(int moveDistance) 
    {
        m_MoveDistance = moveDistance;
    }
  
}
