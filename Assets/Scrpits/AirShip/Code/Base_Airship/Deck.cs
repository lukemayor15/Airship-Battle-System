using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : Base_Ship_Component
{
    [SerializeField] private Sc_Deck  m_sc_Deck;
     public Deck_Stats deck_Stats; 
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Setups the base values of the Deck from the scriptable object and call base setup
    protected override void Init()
    {
        deck_Stats = new Deck_Stats();
        m_sc_Base_Ship_Component = m_sc_Deck;
        base.Init();
    }
}
