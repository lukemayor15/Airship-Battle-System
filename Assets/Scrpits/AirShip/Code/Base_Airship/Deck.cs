using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : BaseShipComponent
{
    [SerializeField] private Sc_Deck  m_sc_Deck;
     public DeckStats deck_Stats; 
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
        deck_Stats = new DeckStats();
        m_scBaseShipComponent = m_sc_Deck;
        base.Init();
    }
}
