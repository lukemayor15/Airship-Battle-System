using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemySelectEnabled : MonoBehaviour
{
    public List<Button> m_enemyButtons;
    // Start is called before the first frame update

    private void Awake()
    {
        ActionSelect.onActionSelected += Enable;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Enable()
    {
        foreach (Button button in m_enemyButtons)
        {
            button.interactable = true;
        }

    }
}
