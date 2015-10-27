using UnityEngine;
using System.Collections;

public class ForLooop : MonoBehaviour
{
	int numMonsters = 7;
	
	
	void Start ()
	{
		for(int i = 0; i < numMonsters; i++)
		{
			Debug.Log("Creating Monster number: " + i);
		}
	}
}