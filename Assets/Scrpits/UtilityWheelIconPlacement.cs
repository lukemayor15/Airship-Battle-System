using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Contains utility functions to help with placing Icons in line with the Ui 
//wheel icon that the player users to select there action, this treats the sprite as a circle instead of a square,
//this should only be used for circle in sprites.
public static class UtilityWheelIconPlacement
{
    //Take into the bound of the ships wheel, its transform and scale to get the length
    static public float calculateSideLength(float bound, float circleTransform, float scale)
    {
        return  bound * scale/2;
    }  
    
    static public Vector3 CalulateVectorForMaxX(float bound, Transform circleTransform)
    {
        float maxX = calculateSideLength(bound, circleTransform.transform.localPosition.x, circleTransform.transform.localScale.x);
        return new Vector3(circleTransform.transform.position.x + maxX, circleTransform.transform.position.y, circleTransform.transform.position.z);
    }

    static public Vector3 CalulateVectorForMaxY(float bound, Transform circleTransform)
    {
        float maxY = calculateSideLength(bound, circleTransform.transform.localPosition.x, circleTransform.transform.localScale.x);
        return new Vector3(circleTransform.transform.position.x , circleTransform.transform.position.y + maxY, circleTransform.transform.position.z);
    }

    static public Vector3 CalulateVectorForMinX(float bound, Transform circleTransform)
    {
        float minX = calculateSideLength(bound, circleTransform.transform.localPosition.x, circleTransform.transform.localScale.x);
        return new Vector3(circleTransform.transform.position.x - minX, circleTransform.transform.position.y, circleTransform.transform.position.z);
    }

    static public Vector3 CalulateVectorForMinY(float bound, Transform circleTransform)
    {
        float minY = calculateSideLength(bound, circleTransform.transform.localPosition.x, circleTransform.transform.localScale.x);
        return new Vector3(circleTransform.transform.position.x, circleTransform.transform.position.y - minY, circleTransform.transform.position.z);
    }

    static public Vector3 CalulateVectorForMaxXMaxY(float bound, Transform circleTransform)
    {
        float sqrtBound = Mathf.Sqrt(bound);
        float maxX = calculateSideLength(sqrtBound, circleTransform.transform.localPosition.x, circleTransform.transform.localScale.x);
        return new Vector3(circleTransform.transform.position.x + maxX, circleTransform.transform.position.y + maxX, circleTransform.transform.position.z);
    }

    static public Vector3 CalulateVectorForMaxXMinY(float bound, Transform circleTransform)
    {
        float sqrtBound = Mathf.Sqrt(bound);
        float maxY = calculateSideLength(sqrtBound, circleTransform.transform.localPosition.x, circleTransform.transform.localScale.x);
        return new Vector3(circleTransform.transform.position.x + maxY, circleTransform.transform.position.y - maxY, circleTransform.transform.position.z);
    }

    static public Vector3 CalulateVectorForMinXMaxY(float bound, Transform circleTransform)
    {
        float sqrtBound = Mathf.Sqrt(bound);
        float minX = calculateSideLength(sqrtBound, circleTransform.transform.localPosition.x, circleTransform.transform.localScale.x);
        return new Vector3(circleTransform.transform.position.x - minX, circleTransform.transform.position.y + minX, circleTransform.transform.position.z);
    }

    static public Vector3 CalulateVectorForMinXMinY(float bound, Transform circleTransform)
    {
        float sqrtBound = Mathf.Sqrt(bound);
        float minY = calculateSideLength(sqrtBound, circleTransform.transform.localPosition.x, circleTransform.transform.localScale.x);
        return new Vector3(circleTransform.transform.position.x - minY, circleTransform.transform.position.y - minY, circleTransform.transform.position.z);
    }

}
