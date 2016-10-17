using UnityEngine;
using System.Collections;

public class Countdown : MonoBehaviour {

	public float countdownTimer = 5.0f; 	// initial starting for countdown
	public TextMesh countdownMesh; 			// countdown textMesh

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (countdownTimer <= 0) {
			movePlatform ();
		} else {
			updateTextGameObject ();
		}
	}

	void updateTextGameObject() {
		countdownTimer = countdownTimer - Time.deltaTime;

		if (countdownTimer > 0) {
			if (countdownMesh)
				countdownMesh.text = "Falling in... " + countdownTimer.ToString ("f0");
		} else {
			if (countdownMesh)
				countdownMesh.text = "DROP";
		}
	}

	void movePlatform() {
		GameObject platform = GameObject.FindGameObjectWithTag ("Platform");
		if (platform)
			platform.SetActive (false);
	}
		
}
