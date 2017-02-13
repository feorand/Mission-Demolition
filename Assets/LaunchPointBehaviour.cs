using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPointBehaviour : MonoBehaviour {
	public void OnMouseEntered() {
		gameObject.SetActive(true);
	}

	public void OnMouseExited() {
		gameObject.SetActive(false);
	}
}
