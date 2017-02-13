using UnityEngine;

public class ProjectileFiringBehaviour : MonoBehaviour {

	Vector3 launchPosition;

	public void Awake() { 
		launchPosition = GameObject.Find("Launch Point").transform.position;
	}

	public void Update() {
		var mouseCoords2D = Input.mousePosition;
		mouseCoords2D.z = -Camera.main.transform.position.z;
		var mouseCoords3D = Camera.main.ScreenToWorldPoint(mouseCoords2D);

		var mouseDelta = mouseCoords3D - launchPosition;
		var maxDistance = GameObject.Find("Slingshot").GetComponent<SphereCollider>().radius;

		if (mouseDelta.magnitude > maxDistance) {
			mouseDelta.Normalize();
			mouseDelta *= maxDistance;
		}

		transform.Translate(launchPosition + mouseDelta);
	}
}
