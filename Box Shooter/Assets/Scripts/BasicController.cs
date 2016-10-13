using UnityEngine;
using System.Collections;

public class BasicController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Horizontal Input = " + Input.GetAxis ("Horizontal"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
