using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats 
{
    NameStat m_nameStat;
    HealthStat m_healthStat;
    ArmorStat m_armorStat;
    HitChanceStat m_hitChanceStat;
    DestroyedStat m_destroyedStat;
    TargetableStat m_targetableStat;

   public BaseStats(string name, int health, int armor, int hitChance, bool destroyed, bool targetable )
    {
        m_nameStat = new NameStat(name);
        m_healthStat = new HealthStat(health);
        m_armorStat = new ArmorStat(armor);
        m_hitChanceStat = new HitChanceStat(hitChance);
        m_destroyedStat = new DestroyedStat(destroyed);
        m_targetableStat = new TargetableStat(targetable);
    }

}
