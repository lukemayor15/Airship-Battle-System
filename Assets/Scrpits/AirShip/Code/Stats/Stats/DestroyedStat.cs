using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedStat : BaseStat
{
    bool m_destroyed;

    public DestroyedStat(bool destroyed)
    {
        m_destroyed = destroyed;
    }
}
