using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    //public Item goldCoin = new Item();
    public Item goldCoin;

    //the sword is an Item, because Weapon inherits Item
    public Weapon sword;

    //bread also inherits from Item
    public Consumable bread;

    // Start is called before the first frame update
    void Start()
    {
        goldCoin = new Item();
        sword = new Weapon();
        bread = new Consumable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class Item
{
    public string _name;
    public int itemID;
    public Sprite icon;
}

[System.Serializable]
public class Weapon : Item
{
    public int attackBonus;
    public int prayerBonus;
    public int StrengthBonus;
    public int WageBonus;
}

[System.Serializable]
public class Consumable : Item
{
    public int addedHealth;
    public bool poison;
}