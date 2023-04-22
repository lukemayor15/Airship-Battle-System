using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Stats 
{
    Name_stat m_nameStat;
    Health_Stat m_healthStat;
    Armor_Stat m_armorStat;
    HitChance_Stat m_hitChanceStat;
    Destroyed_Stat m_destroyedStat;
    Targetable_Stat m_targetableStat;

   public Base_Stats(string name, int health, int armor, int hitChance, bool destroyed, bool targetable )
    {
        m_nameStat = new Name_stat(name);
        m_healthStat = new Health_Stat(health);
        m_armorStat = new Armor_Stat(armor);
        m_hitChanceStat = new HitChance_Stat(hitChance);
        m_destroyedStat = new Destroyed_Stat(destroyed);
        m_targetableStat = new Targetable_Stat(targetable);
    }

}
