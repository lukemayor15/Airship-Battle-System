using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manoeurving_stat : Base_Stat
{
    [SerializeField] private int m_manoeurving;

    Manoeurving_stat(int manoeurving)
    {
        m_manoeurving = manoeurving;
    }
}
