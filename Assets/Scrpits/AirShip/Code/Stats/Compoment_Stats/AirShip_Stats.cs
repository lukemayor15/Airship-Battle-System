using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirShip_Stats 
{
    Name_stat m_nameStat;
    Health_Stat m_healthStat;
    Armor_Stat m_armorStat;
    HitChance_Stat m_hitChanceStat;
    Manoeurving_stat m_manoeuvringStat;
    Speed_Stat m_speedStat;
    ActionPoints_Stat m_actionPointsStat;

    public AirShip_Stats(int manoeuvring, int speed, int actionPoints, string name, int health, int armor, int hitChance)
    {
        m_manoeuvringStat = new Manoeurving_stat(manoeuvring);
        m_speedStat = new Speed_Stat(speed);
        m_actionPointsStat = new ActionPoints_Stat(actionPoints);
        m_nameStat = new Name_stat(name);
        m_healthStat = new Health_Stat(health);
        m_armorStat = new Armor_Stat(armor);
        m_hitChanceStat = new HitChance_Stat(hitChance);
    }

}
