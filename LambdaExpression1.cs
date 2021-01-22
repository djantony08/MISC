using System;
using System.Collections;							
using System.Collections.Generic;					
using UnityEngine;

//Function Delegates aka Return Type delegates
//A void delegate public delegate void xxXXX does not return anything

public class Main : MonoBehaviour
{
	//public delegate int CharacterLength (string text);
	
	public Func<string,int> CharacterLength; //<<<<<-pass in a String, but returns an int !
	
	
	void Start()
	{
		//CharacterLength = GetCharacters;
		
		//Lambda knows name is a string from the Func<string,int> 
		CharacterLength = (name) => name.Length;
		int _charCount = CharacterLength("Jon");
		Debug.log("Character Count = "+_charCount);
	}
	
	/*
	int GetCharacters(string name)
	{
		//returns the length of someone name E.g. Bob = 3
		return name.Length;
	}
	*/
}