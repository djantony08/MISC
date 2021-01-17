using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour
{
	//Variables
	public string companyName="GameDevHQ";
	public string employeeName;

	//the class inheriting Enemy1 must implement the CalculateMonthlySalary(); method
	public abstract void CalculateMonthlySalary();
}

public class PartTime : Employee
{
	public int _hoursWorked;
	public int _hourlyRate;
	
	public override void CalculateMonthlySalary()
	{
		//Debug.Log("");
	}
}

public class FullTime : Employee
{
	public int _salary;
	
	public override void CalculateMonthlySalary()
	{
		//Debug.Log("");
	}
}



