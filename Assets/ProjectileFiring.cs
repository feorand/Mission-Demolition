using UnityEngine;

public class ProjectileFiring : MonoBehaviour {

	Vector3 launchPosition;

	public void Awake() { 
		launchPosition = GameObject.Find("Launch Point").transform.position;
	}

	public void Update() {


		//var mouseDelta = mouseCoords3D - launchPosition;
		//var maxDistance = GameObject.Find("Slingshot").GetComponent<SphereCollider>().radius;

		//if (mouseDelta.magnitude > maxDistance) {
		//	mouseDelta.Normalize();
		//	mouseDelta *= maxDistance;
		//}

		//transform.Translate(launchPosition + mouseDelta);
	}
}
