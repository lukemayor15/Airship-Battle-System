using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thariship game object and assigns the releveant sprites based, 
public class GenerateAirShipSprite: MonoBehaviour
{
    //Take a list of the sprites and replace the images
    [SerializeField] private List<SpriteRenderer> spriteRenderersWeapones;
    [SerializeField] private List<GameObject> spriteRenderersWeaponesTest;

    [SerializeField] private SpriteRenderer wheel;
    [SerializeField] private Canvas canvas;


    private void Start()
    {
        
    }

    public void SetSprites(Airship airship)
    {
       
        for (int i = 0; i <airship.WeaponTypesList.Count; i++)
        {

            spriteRenderersWeapones[i].sprite = airship.WeaponTypesList[i].WeaponTypes.Sprite;
            airship.test_button.transform.position = canvas.worldCamera.WorldToScreenPoint(spriteRenderersWeaponesTest[i].transform.position);
        }
    }
}
