using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Base : BaseShipComponent
{
    private int m_slotId = 0;
    private int m_damage = 0;
    [SerializeField] private int m_actionPointCost;
    [SerializeField] private int m_range;
    protected IDoDamage m_damageType;
    protected Sc_WeaponTypes m_sc_WeaponType;

    //-------properties-----------//

    public Sc_WeaponTypes WeaponTypes
    {
        set { m_sc_WeaponType = value; }
        get { return m_sc_WeaponType; }

    }
    public IDoDamage DamageType
    {
        set { m_damageType = value; }
    }
    public int Damage
    {
        get { return m_damage; }
    }
    public int ActionPointCost
    {
        get { return m_actionPointCost; }
    }
    public int Range
    {
        get { return m_range; }
    }

    public int SlotId
    {
        get { return m_slotId; }
    }

    // Start is called before the first frame update
    void  Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryDoAttack()
    {
        Debug.Log(m_sc_WeaponType);
        m_damageType.DoDamage(m_damage);
    }

    protected override void Init()
    {
        this.m_scBaseShipComponent = m_sc_WeaponType;
        this.m_range = m_sc_WeaponType.Range;
        this.m_damage = m_sc_WeaponType.Damage;
        base.Init();
    }

    public void Init(Sc_WeaponTypes sc_WeaponType , int Id)
    {
        this.m_slotId = Id;
        m_sc_WeaponType = sc_WeaponType;
        Init();
    }


}
