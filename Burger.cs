using UnityEngine;
using System.Collections;

public class Burger : MonoBehaviour
{
	public Camera mainCamera;
	public Transform tomato, lettuce, cheese, onion;

	public static int num;
	int food, min = 1, max = 6, space = 0;
	public static string[] hamburger = new string[7];
	public static bool make = false;

	void Update ()
	{
		if(!make)
		{
			space = -1;
			MakeBurger ();
			make = true;
			GameScore.score += 100;
		}

		if(GameScore.score > 1000)
		{
			min = 3;
			max = 8;
		}
	}

	void MakeBurger()
	{
		num = Random.Range (min, max);

		for(int i = 0; i < num; i++)
		{
			food = Random.Range (0, 4);  //0 to 3
			
			switch (food)
			{
			case 0:
				Instantiate(tomato, new Vector3(mainCamera.ScreenToWorldPoint (new Vector3 (6*Screen.width/10, 0f, 0f)).x + space, mainCamera.ScreenToWorldPoint(new Vector3(0f, 4*Screen.height/5, 0f)).y, 0f), Quaternion.identity);
				hamburger[i] = "Tomato(Clone)";
				break;
			case 1:
				Instantiate(lettuce, new Vector3(mainCamera.ScreenToWorldPoint (new Vector3 (6*Screen.width/10, 0f, 0f)).x + space, mainCamera.ScreenToWorldPoint(new Vector3(0f, 4*Screen.height/5, 0f)).y, 0f), Quaternion.identity);
				hamburger[i] = "Lettuce(Clone)";
				break;
			case 2:
				Instantiate(cheese, new Vector3(mainCamera.ScreenToWorldPoint (new Vector3 (6*Screen.width/10, 0f, 0f)).x + space, mainCamera.ScreenToWorldPoint(new Vector3(0f, 4*Screen.height/5, 0f)).y, 0f), Quaternion.identity);
				hamburger[i] = "Cheese(Clone)";
				break;
			case 3:
				Instantiate(onion, new Vector3(mainCamera.ScreenToWorldPoint (new Vector3 (6*Screen.width/10, 0f, 0f)).x + space, mainCamera.ScreenToWorldPoint(new Vector3(0f, 4*Screen.height/5, 0f)).y, 0f), Quaternion.identity);
				hamburger[i] = "Onion(Clone)";
				break;
			default:
				break;
			}
			space++;
		}
	}
}
