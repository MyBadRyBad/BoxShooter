using UnityEngine;
using System.Collections;

public class CountdownScript : MonoBehaviour {

	public float countdownTimer = 5.0f; 	// initial starting for countdown
	public TextMesh textMesh; 				// countdown textMesh
	public GameObject disableObject;			// object to hide when countdown reaches 0



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (countdownTimer < 0) {
			disableGameObject ();
		} else {
			updateTextGameObject ();
		}
	}

	void updateTextGameObject() {
		countdownTimer = countdownTimer - Time.deltaTime;
		if (textMesh) {
			//string countdownString = string.Format ("{0:D}", (int)countdownTimer / 60, (int)countdownTimer % 60);
			textMesh.text = countdownTimer.ToString("f0");
		}
	}

	void disableGameObject() {
		disableObject.SetActive (false);
	}
		
}
