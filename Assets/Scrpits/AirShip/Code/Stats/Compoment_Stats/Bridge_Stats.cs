using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Stats 
{
    ActionPoints_Stat  m_actionPointsStat;
   
    public Bridge_Stats(int actionPoints)
    {
        m_actionPointsStat = new ActionPoints_Stat(actionPoints);
    }
   
}
