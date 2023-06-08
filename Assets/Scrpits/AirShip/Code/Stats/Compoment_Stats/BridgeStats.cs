using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeStats 
{
    ActionPointsStat  m_actionPointsStat;
   
    public BridgeStats(int actionPoints)
    {
        m_actionPointsStat = new ActionPointsStat(actionPoints);
    }
   
}
