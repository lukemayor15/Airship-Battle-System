using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetable_Stat : Base_Stat
{
    bool m_targetable;
    public Targetable_Stat(bool targetable)
    {
        m_targetable = targetable;
    }
}
