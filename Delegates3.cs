using System;
using System.Collections;							
using System.Collections.Generic;					
using UnityEngine;

//Function Delegates using keyword func
//A void delegate public delegate void xxXXX does not return anything
//

public class Main : MonoBehaviour
{
	public delegate string OnComplete;
	
	int GetCharacters(string name)
	{
		//returns the length of someone name E.g. Bob = 3
		return name.Length;
	}
}