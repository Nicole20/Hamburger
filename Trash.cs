using UnityEngine;
using System.Collections;

public class Trash : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D chefInfo)
	{
		if(chefInfo.tag == "Player" && ChefControl.hold == true)
		{
			ChefControl.food = null;
			ChefControl.hold = false;
		}
	}
}
