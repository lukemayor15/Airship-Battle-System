using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Stats 
{

    [SerializeField] private string m_name;
    //[SerializeField] private Dictionary<string, Base_Stat> m_stats_Dictionary =  new Dictionary<string, Base_Stat>();
    [SerializeField] private DictionaryClass<string, Base_Stat> m_stats_Dictionary =  new DictionaryClass<string,Base_Stat>();
    // Start is called before the first frame update


 

    //Takes in a airship of a scritable objects and it compoments to calulate the airship stats
    //Createa genric stats class, that contains a map with the stat and name and it values to allow
    //for the looping of adding the common stats together instead of manually having to add each stat
    public  Stats()
    {
        //Construct inital stats
        //m_moveDistance = new MoveDistance_Stat();
        //m_speed = new Speed_Stat();
        //m_manoeurving = new Manoeurving_stat();
        //m_armor = new Armor_Stat();
        //m_health = new Health_Stat();
        //m_actionPoints = new ActionPoints_Stat();
    }


    //add to dict utilites func


}



//Move to sepreate class
//Create constant in a stat namespace use for lookup
//figure out how to use them for the different compoments and how we replace the stats.
public class DictionaryClass<T1,T2>
{

    [SerializeField] public Dictionary<T1, T2> m_stats_Dictionary = new Dictionary<T1, T2>();

    public DictionaryClass()
    {
    }

    public void Add(T1 Key, T2 value)
    {
        m_stats_Dictionary.Add(Key, value);
    }
}
