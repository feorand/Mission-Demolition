using UnityEngine;

public class LightSwitcher : MonoBehaviour {
	public GameObject launchPoint;

	public void OnMouseEnter() {
		launchPoint.SetActive(true);
	}

	public void OnMouseExit() {
		launchPoint.SetActive(false);
	}
}
