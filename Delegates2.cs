using System.Collections;									
using System.Collections.Generic;									
using UnityEngine;									
									
public class MAIN : MonoBehaviour									
{									
	//prog = turn all cubes red								
									
	//ActionClick() will store the ButtonClick()method								
	public delegate void ActionClick(); // << Delegate Signature				
	public static event ActionClick onClick;								
									
	public void ButtonClick()								
	{								
		//if the event is null, it will cause an error							
		//we want to call the event for listeners the cube							
		if(onClick != null)							
		{							
			//turn all cubes red						
			onClick();						
		}							
									
	}								
}									

public class Cube : MonoBehaviour									
{									
    // Start is called before the first frame update				
    void Start()									
    {									
        MAIN.onClick += TurnRed;									
    }									
									
    // Update is called once per frame								
    public void TurnRed()									
	{								
        GetComponent<MeshRenderer>().material.color = Color.red;	
	}								
}									

puboic class Sphere : Monobehaviour
{
	public void Fall()
	{
		GetComponent<Rigidbody>().useGravity = true;
	}
}
