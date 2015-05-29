using UnityEngine;
using System.Collections;

public class FoodControl : MonoBehaviour
{
	bool hold = false;
	public Collider2D chef;

	void Update()
	{
		if(ChefControl.hold == false)
		{
			transform.position = transform.parent.transform.position;
			hold = false;
		}
		else if(hold)
		{
			transform.position = chef.transform.position;
		}
	}

	void OnTriggerEnter2D (Collider2D chefInfo)
	{
		if(chefInfo.tag == "Player" && hold == false && ChefControl.hold == false)
		{
			transform.position = chefInfo.transform.position;
			
			hold = true;
			ChefControl.hold = true;
			ChefControl.food = name + "(Clone)";
		}
	}
}
