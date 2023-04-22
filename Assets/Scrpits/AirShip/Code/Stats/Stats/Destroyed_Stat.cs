using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyed_Stat : Base_Stat
{
    bool m_destroyed;

    public Destroyed_Stat(bool destroyed)
    {
        m_destroyed = destroyed;
    }
}
