using UnityEngine;
using System.Collections;

public class ChefControl : MonoBehaviour
{
	public KeyCode moveUp, moveDown, moveRight, moveLeft;
	
	public float speed = 1;

	public static bool hold = false;
	public static string food;

	void Update ()
	{
		Vector2 v = rigidbody2D.velocity;
		
		if(Input.GetKey(moveUp))
		{
			v.y = speed;
		}
		else if(Input.GetKey(moveDown))
		{
			v.y = -speed;
		}
		else
		{
			v.y = 0;
		}
		
		if(Input.GetKey(moveRight))
		{
			v.x = speed;
		}
		else if(Input.GetKey(moveLeft))
		{
			v.x = -speed;
		}
		else
		{
			v.x = 0;
		}
		
		rigidbody2D.velocity = v;
	}
}
