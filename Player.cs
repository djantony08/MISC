using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
	public GameObject laserPrefab;
	public Transform firePos;

	[SerializeField]
	private float _speed;

	private WeaponStats blasters;
	private WeaponStats rockets;

	void Start()
	{
														
		/*Created the object blasters an instance of the class											
		WeaponStats blasters = new WeaponStats();											
													
		blasters = new WeaponStats();											
		blasters.name = "MegaBlasters";											
		blasters.fireRate = 0.25f;											
		blasters.ammoCount = 50;											
													
		rockets = new WeaponStats();											
		rockets.name = "Rockets";											
		rockets.fireRate =5.0f;											
		rockets.ammoCount =1;
		*/
		
		blasters = new WeaponStats("blasters", 0.25f, 50);
		rockets = new WeaponStats("Rockets", 5f, 1);

		Debug.Log("Current Weapon Name = " + blasters.name);
	}

	// Update is called once per frame													
	void Update()
	{
		CalcMovement();
		Shoot();
	}

	void CalcMovement()
	{
		float hInput = Input.GetAxis("Horizontal");
		float vInput = Input.GetAxis("Vertical");

		transform.Translate(new Vector3(hInput, vInput, 0) * _speed * Time.deltaTime);

		if (transform.position.x > 8.5f)
		{
			transform.position = new Vector3(8.5f, transform.position.y, 0);
		}
		else if (transform.position.x < -8.5f)
		{
			transform.position = new Vector3(-8.5f, transform.position.y, 0);
		}
	}

	void Shoot()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(laserPrefab, firePos.position, Quaternion.identity);
		}
	}
}

public class WeaponStats
{
	//Object class. Does not inherit monobehaviour												
	public string _name;
	public float _fireRate;
	public int _ammoCount;
	internal string name; //tba

	//Constructors - used to initialise objects												
	public WeaponStats(string name, float fireRate, int ammoCount)
	{
		this._name = name;
		this._fireRate = fireRate;
		this._ammoCount = ammoCount;
	}
}

