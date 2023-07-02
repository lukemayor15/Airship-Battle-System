using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipInitalisedDelgate
{
    public delegate void OnAirshipInitalised(Airship airship);
    public static OnAirshipInitalised onAirshipInitalised;
}
