using UnityEngine;
using UnityEngine.Events;

public class MouseInteractor : MonoBehaviour {
	public GameObject projectilePrefab;
	public UnityEvent MouseEntered;
	public UnityEvent MouseExited;
	public UnityEvent MouseDown;

	void OnMouseEnter() {
		MouseEntered.Invoke();
	}

	void OnMouseExit() {
		MouseExited.Invoke();
	}

	public void OnMouseDown()
	{
		var projectile = Instantiate(projectilePrefab) as GameObject;
		var launchPointPosition = GameObject.Find("Launch Point").transform.position;
		projectile.transform.position = launchPointPosition;
		projectile.GetComponent<Rigidbody>().isKinematic = true;
		MouseDown.Invoke();
	}

	public void OnMouseUp() {
		Destroy(GameObject.Find("Projectile(Clone)"));
	}
}
