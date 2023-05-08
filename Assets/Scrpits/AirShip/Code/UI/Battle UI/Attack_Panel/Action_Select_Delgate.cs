using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handles the logic when an action have been select, this is triggerd when an attacl button is pressed and enabled the selecting of targetable objects.
public class ActionSelect
{

    public delegate void OnActionSelected();
    public static OnActionSelected onActionSelected;

}
