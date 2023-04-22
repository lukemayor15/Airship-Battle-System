using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Ship_Component : MonoBehaviour
{
    [SerializeField] protected Sc_Base_Ship_Component m_sc_Base_Ship_Component;
    [SerializeField] public Base_Stats m_baseStats;
 

    //==========properties============
   


    // Start is called before the first frame update
    public void Start()
    {
        Init();
    }
    //Init the compoment with the scritable object that contains it stats
    //This creates the base stats from the scritable object, if there is need for additonal stats,
    //create a new class for the compoment stats and add the3se into the compoment class, for an example look at the Hull class
    protected virtual void Init()
    {
        //Create the base stats for each compoment
        m_baseStats = new Base_Stats(m_sc_Base_Ship_Component.Name, m_sc_Base_Ship_Component.Health, m_sc_Base_Ship_Component.Armor, m_sc_Base_Ship_Component.HitChance,
        m_sc_Base_Ship_Component.Destroyed, m_sc_Base_Ship_Component.Targetable);

    }
    //Consider making into an interface, as other elements may need to get damaged
    //THis will Apply the damage a ship/Compoment Take
    protected void TakeDamage()
    {
        Debug.LogError("Not implemented TakeDamage");
    }

    //THis will return the damage a ship/Compoment Take
    protected void CalulateDamage()
    {
        Debug.LogError("Not implemented CalulateDamage");
    }
}
