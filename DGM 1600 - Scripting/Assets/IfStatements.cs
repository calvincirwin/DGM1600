using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
	public float age = 0f;
	public float adult = 21f;
	public float seniorCitizen = 65f;

	
	
	
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space))
			ageChange ();

		age += Time.deltaTime * 5f;
	}
	void ageChange ()
		{
			// If the coffee's temperature is greater than the hottest drinking temperature...
			if(age < 21)
			{
				// ... do this.
				print("You are not a legal adult");
			}
			// If it isn't, but the coffee temperature is less than the coldest drinking temperature...
			else if(age > 65)
			{
				// ... do this.
				print("You are a Senior Citizen.");
			}
			// If it is neither of those then...
			else
			{
				// ... do this.
				print("You are an adult");
			}
	}

}
