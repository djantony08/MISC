using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wizard : MonoBehaviour
{
	//public RpgSpell fireBlast;
	public RpgSpell[] rpgspells = new RpgSpell[2];

	public int level = 1;
	public int exp;

	//Wizard can have an array of different spells that it can cast
    void Start()
    {
		//fireBlast = new RpgSpell("Fireblast", 1, 27, 35);    
    }

    // Update is called once per frame
    void Update()
    {
		/*
		//Cast a spell every time the space key is hit
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//fireBlast.Cast();
			//exp += fireBlast._expGained;
		}
		*/

		//Iterate through the spell list and compare to my current level
		//cast spell

		foreach(var rpgspell in rpgspells)
		{
			if(rpgspell._levelReq == level)
			{
				rpgspell.Cast();
				exp += rpgspell._expGained;
			}
		}
    }

[System.Serializable]
public class RpgSpell
{
	//RpgSpell requirements
	public string _name; //name of spell
	public int _levelReq; //level required
	public int _itemIdReq; //spell ref or id
	public int _expGained; //spell experience gained
	//internal int levelReq;

		//RpgSpell Constructor i.e. min req's to create an rpgspell
	public RpgSpell(string name, int levelReq, int itemIdReq, int expGained)
	{
		this._name = name;
		this._levelReq = levelReq;
		this._itemIdReq = itemIdReq;
		this._expGained = expGained;
	}

	public void Cast()
	{
		Debug.Log("Casting = "+this._name);
	}
}









}


