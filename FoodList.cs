using UnityEngine;
using System.Collections;

public class FoodList : MonoBehaviour
{
	int count = 0;

	void Update()
	{
		for(int i = 0; i < Burger.num; i++)
		{
			if(Burger.hamburger[i] == null)
			{
				count++;
			}
		}

		if(count == Burger.num)
		{
			Burger.make = false;
		}

		count = 0;
	}
	
	void OnTriggerEnter2D (Collider2D chefInfo)
	{
		if(chefInfo.tag == "Player" && ChefControl.hold == true)
		{
			if(ChefControl.food == name)
			{
				Destroy(gameObject);
				ChefControl.food = null;
				ChefControl.hold = false;

				for(int i = 0; i < Burger.num; i++)
				{
					if(Burger.hamburger[i] == name)
					{
						Burger.hamburger[i] = null;
						GameScore.score += 10;
						break;
					}
				}
			}
		}
	}
}
