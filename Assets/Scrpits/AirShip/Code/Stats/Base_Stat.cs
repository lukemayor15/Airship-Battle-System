using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public  class Base_Stat
{
    [SerializeField] private string m_name;
    [SerializeField] protected string m_description;

    public string Name { get => m_name; set => m_name = value; }
    public string Description { get => m_description; set => m_description = value; }
  }







