using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemDB : MonoBehaviour
{
	public List<Item> itemList = new List<Item>();
	
	public Dictonary< int, Item2> itemDictionary = new Dictionary<int, Item>();
	
	void Start()
	{
		Item sword = new Item();
		sword.name = "Sword";
		sword.id = 0;
		itemDictionary.Add(0, new Item());
	}
	
}


[System.Serializable]
public class Item2 : MonoBehaviour
{
	public string name;
	public int id;
	
}






