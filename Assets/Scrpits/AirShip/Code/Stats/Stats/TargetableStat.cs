using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetableStat : BaseStat
{
    bool m_targetable;
    public TargetableStat(bool targetable)
    {
        m_targetable = targetable;
    }
}
