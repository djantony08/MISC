using System.Collections;				
using System.Collections.Generic;		
using UnityEngine;						

//Attach to GameObject in Scene
public class EnemyAI : MonoBehaviour
{										
	public enum EnemyState
	{
		Patrolling,
		Attacking,
		Chasing,
		Death
	}
	
	public EnemyState currentState;
	
	void Start()
	{
		currentState = EnemyState.Patrolling;
	}
	
	void Update()
	{
		switch(currentState)
		{
			case EnemyState.Patroling:
				Debug.Log("Patrolling")
				if(Time.time > 5)
				{
					currentState = EnemyState.Chasing;
				}
				break;
			case EnemyState.Attacking:
			    Debug.Log("Attacking")
				break;
			case EnemyState.Chasing:
				Debug.Log("Chasing")
				break;
			case EnemyState.Death:
				Debug.Log("Death")
				break;
		}
	}
	
	if(Input.GetKeyDown(KeyCode.Space))
	{
		currentState = EnemyState.Attacking;
	}
}


