using System.Collections;				
using System.Collections.Generic;		
using UnityEngine;						

public class SelectedDifficulty : MonoBehaviour
{										
	//public int easy, normal, hard, currentSelectedLevel
	
	public enum LevelSelector
	{
		Easy = 0, //0
		Normal = 1, //1
		Hard = 2, //2
		Expert = 3 //3
	}
	
	public LevelSelector currentLevel;
	
	void Start()
	{
		switch(currentLevel)
		{
			case LevelSelector.Easy:
				Debug.log("You Selected Easy !");
				break;
			case LevelSelector.Normal:
				Debug.log("You Selected Normal !");
				break;
			case LevelSelector.Hard:
				Debug.log("You Selected Hard !");
				break;
			case LevelSelector.Expert:
				Debug.log("You Selected Expert !");
			default:
				Debug.Log("Invalid Selection !")
				break;
		}
	}
	
}


