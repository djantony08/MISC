using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{
    //In a static class important to 
    //know you cannot inherit from anything

    public static int myAge;

    public static void CreateObject()
	{
        //Create a new primitive cube
        GameObject.CreatePrimitive(PrimitiveType.Cube);
	}

    public static void SetPositionToZero(GameObject obj)
	{
        //Change position of obj
        obj.transform.position = Vector3.zero;
	}
    
}
