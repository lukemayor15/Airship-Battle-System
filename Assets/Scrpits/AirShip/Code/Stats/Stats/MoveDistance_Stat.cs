using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDistance_Stat : Base_Stat
{
    [SerializeField] private int m_MoveDistance;

    MoveDistance_Stat(int moveDistance) 
    {
        m_MoveDistance = moveDistance;
    }
  
}
