using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMover : MonoBehaviour {
	public int maxDistance;
	Vector3 launchPosition;

	public void Awake()
	{
		launchPosition = GameObject.Find("Launch Point").transform.position;
	}

	void Update () {
		var mouseCoords3D = PlayerStatus.MousePosition3D;
		var mouseDelta = mouseCoords3D - launchPosition;

		if (mouseDelta.magnitude > maxDistance) {
			mouseDelta.Normalize();
			mouseDelta *= maxDistance;
		}

		transform.Translate(launchPosition + mouseDelta);
	}
}
