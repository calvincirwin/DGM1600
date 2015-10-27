using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour 
{   
	void Start () 
	{
		string[] strings = new string[4];
		
		strings[0] = "Foster";
		strings[1] = "Calvin";
		strings[2] = "Xander";
		strings[3] = "Jon-Jon";		
		foreach(string brothers in strings)
		{
			print (brothers);
		}
	}
}