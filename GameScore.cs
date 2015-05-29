using UnityEngine;
using System.Collections;

public class GameScore : MonoBehaviour
{
	public static int score = -100;
	
	public GUISkin theSkin;

	void OnGUI()
	{
		GUI.skin = theSkin;
		GUI.Label (new Rect (Screen.width / 2 - 10, Screen.height - 50, 100, 100), "" + score);
	}
}
