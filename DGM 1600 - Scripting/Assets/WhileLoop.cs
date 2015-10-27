using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
	int tasksToDo = 5;
	
	
	void Start ()
	{
		while(tasksToDo > 0)
		{
			Debug.Log ("I've completed the tasks!!!");
			tasksToDo--;
		}
	}
}