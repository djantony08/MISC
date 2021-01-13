using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	/*Challenge: Create a list/array of 3 gameObject to spawn and randomly spawn them 
	with a random position on the screen between -10 and +10 on the X/Y when you hit the Space Key.
	Every object you spawn should be stored into a list called ObjectsCreated.
	When you have spawned 10 objects. We stop spawning, and turn all objects created GREEN then clear the list
	*/
	public GameObject[] SpawnList = new GameObject[3];
	public List<GameObject> objectsCreated = new List<GameObject>();
	public int SpawnCount {get; set;}

	private bool _initColorChange=false;


	void Start()
	{
		
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			if(SpawnCount==10)
			{
				_initColorChange = true;
				return;
			}
			
			//randomly picks one of a cube, sphere or capsule to spawn
			var objectToSpawn = SpawnList[Random.Range(0, SpawnList.Length)];

			//the objects position is randomized

			var x = Random.Range(-10, 10);
			var y = Random.Range(-10, 10);

			//Use Quaternion.Identity to signify no rotation
			//Instantiate(objectToSpawn, new Vector3(x, y, 0), Quaternion.identity);
			var pos = new Vector3(x, y, 0);
			
			//Creating GameObjects
			var go = Instantiate(objectToSpawn, pos, Quaternion.identity) as GameObject;
			objectsCreated.Add(go);
			SpawnCount++;
		}

		if(_initColorChange==true)
		{
			_initColorChange = false;
			
			foreach(var obj in objectsCreated)
			{
				obj.GetComponent<MeshRenderer>().material.color = Color.green;
			}
		}
	}
}
