using System;
using System.Collections;							
using System.Collections.Generic;					
using UnityEngine;

//Actions
public class Player : MonoBehaviour
{
	//public delegate void OnDamageReceived (int currentHealth);
	//public static event OnDamageReceived onDamage;
	
	//public delegate void onComplete = public Action OnComplete
	//public Action onComplete;
	public static Action<int> OnDamageReceived;
	
	public int _health { get; set; }
	
	public void Start()
	{
		_health = 10;
	}
	
	
	/*
	public void Damage()
	{
		_health--;
		if(onDamage !=null)
		{
			onDamage(_health);
		}
		//UIManager.UpdateHealth(_health);
	}
	*/
	
	void Damaage()
	{
		_health--;
		if(OnDamageReceived !=null)
		{
			OnDamageReceived(_health);
		}
	}
	
//--------------------------------------------------
//UIManager
using System;
using System.Collections;							
using System.Collections.Generic;					

public class UIManager : Monobehaviour
{
	public void OnEnable()
	{
		Player.onDamageReceived += UpdateHealth;
	}
	
	public void UpdateHealth(int health)
	{
		Debug.Log("Current Health: "+health);
	}
}