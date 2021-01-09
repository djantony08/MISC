using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
	private Duck duck;
	private Dog dog;
	
	/*changed from public to protected
	so only Child classes that inherit can modify info
	*/
	protected string petName;

	//Virtual access modifier allows Child classes to override the Speak() method
    protected virtual void Speak()
	{
		Debug.Log("Speak !");
	}

	private void Start()
	{
		duck = new Duck();
		dog = new Dog();

		Speak();

		duck.Speak();
		dog.Speak();
	}
}

public class Duck : Pet
{
	protected override void Speak()
	{
		Debug.Log("Quack ! Quack");
	}
}

public class Dog : Pet
{
	protected override void Speak()
	{
		Debug.Log("Bark !");
	}
}
