using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirShipStats 
{
    NameStat m_nameStat;
    HealthStat m_healthStat;
    ArmorStat m_armorStat;
    HitChanceStat m_hitChanceStat;
    ManoeurvingStat m_manoeuvringStat;
    SpeedStat m_speedStat;
    ActionPointsStat m_actionPointsStat;

    public AirShipStats(int manoeuvring, int speed, int actionPoints, string name, int health, int armor, int hitChance)
    {
        m_manoeuvringStat = new ManoeurvingStat(manoeuvring);
        m_speedStat = new SpeedStat(speed);
        m_actionPointsStat = new ActionPointsStat(actionPoints);
        m_nameStat = new NameStat(name);
        m_healthStat = new HealthStat(health);
        m_armorStat = new ArmorStat(armor);
        m_hitChanceStat = new HitChanceStat(hitChance);
    }

}
