using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour {
	public static Vector3 MousePosition3D
	{
		get
		{
			var mouseCoords2D = Input.mousePosition;
			mouseCoords2D.z = -Camera.main.transform.position.z;
			return Camera.main.ScreenToWorldPoint(mouseCoords2D);
		}

	}
}
