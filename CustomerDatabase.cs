using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Create a program to add Customers to a database
Create at least 3 customers via code using a constructor
Add customers through the inspector
2 classes = 1)CustomerDatabase 2)DefineCustomer
Customer Traits = 1)First Name, 2)Last Name, 3)Age, 4)Gender, 5)Occupation
*/

[System.Serializable]
public class CustomerDatabase : MonoBehaviour
{
    private Traits Bob, Tom, Pat;
    
    //create an array of Customer
    // Start is called before the first frame update
    void Start()
    {
        Bob = new Traits("Bob", "Marley", 50, "M","Singer");
        Tom = new Traits("Tom", "Bailey", 23, "M","Diver");
        Pat = new Traits("Pat", "Frank", 45, "F","Mechanic");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Traits
{
    public string _firstName;
    public string _lastName;
    public int _age;
    public string _gender;
    public string _occupation;
    public Sprite _icon;

    public Traits()
	{

	}

    public Traits(string firstName, string lastName, int Age, string Gender, string occupation)
	{
        this._firstName = firstName;
        this._lastName = lastName;
        this._age = Age;
        this._gender = Gender;
        this._occupation = occupation;
	}
}

/*
public class CreateCustomer(string firstName, string lastName, int Age, string occupation)
{
    Traits customer = new Traits(firstName, lastName, Age, occupation);
}

*/
