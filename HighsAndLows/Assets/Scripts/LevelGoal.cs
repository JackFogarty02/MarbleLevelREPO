using UnityEngine;
using System.Collections;

public class LevelGoal : MonoBehaviour {

	public AudioSource playSound;
	
	private GameObject gc;

	void Start()
	{
		gc = GameObject.FindGameObjectWithTag ("GameController");
	}

	void OnTriggerEnter ()
	{
		playSound.Play();

		gc.GetComponent<GameController> ().GoToNextScene ();
	}

}
