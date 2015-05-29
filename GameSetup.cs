using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour
{
	public Camera mainCamera;
	public BoxCollider2D topWall, bottomWall, leftWall, rightWall, wall;

	public Transform chef, tomato, lettuce, cheese, onion, border, block, trash;

	void Start ()
	{
		topWall.size = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f);
		topWall.center = new Vector2 (0f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y + 0.5f);

		bottomWall.size = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f);
		bottomWall.center = new Vector2 (0f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y - 0.5f);

		leftWall.size = new Vector2 (1f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y);
		leftWall.center = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x - 0.4f, 0f);

		rightWall.size = new Vector2 (1f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y);
		rightWall.center = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x + 0.6f, 0f);

		trash.position = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (9*Screen.width/10, 0f, 0f)).x, mainCamera.ScreenToWorldPoint (new Vector3 (0f, Screen.height/5, 0f)).y);

		block.position = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width/2, 0f, 0f)).x, mainCamera.ScreenToWorldPoint(new Vector3(0f, 4*Screen.height/5, 0f)).y);
		border.position = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width/2, 0f, 0f)).x, mainCamera.ScreenToWorldPoint(new Vector3(0f, 4*Screen.height/5, 0f)).y);

		chef.position = new Vector2(0, -1);

		tomato.position = new Vector2(mainCamera.ScreenToWorldPoint (new Vector3 (75f, 0f, 0f)).x, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height/5, 0f)).y);
		lettuce.position = new Vector2(mainCamera.ScreenToWorldPoint (new Vector3 (75f, 0f, 0f)).x, mainCamera.ScreenToWorldPoint(new Vector3(0f, 2*Screen.height/5, 0f)).y);
		cheese.position = new Vector2(mainCamera.ScreenToWorldPoint (new Vector3 (75f, 0f, 0f)).x, mainCamera.ScreenToWorldPoint(new Vector3(0f, 3*Screen.height/5, 0f)).y);
		onion.position = new Vector2(mainCamera.ScreenToWorldPoint (new Vector3 (75f, 0f, 0f)).x, mainCamera.ScreenToWorldPoint(new Vector3(0f, 4*Screen.height/5, 0f)).y);
	}
}
