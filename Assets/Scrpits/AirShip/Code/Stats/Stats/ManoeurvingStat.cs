using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManoeurvingStat : BaseStat
{
    [SerializeField] private int m_manoeurving;

    public ManoeurvingStat(int manoeurving)
    {
        m_manoeurving = manoeurving;
    }
}
