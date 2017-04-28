using UnityEngine;
using UnityEngine.Events;

public class ProjectileSpawner : MonoBehaviour {
	public GameObject projectilePrefab;
	public UnityEvent MouseDown;

	private GameObject projectileSpawn;

	public void OnMouseDown()
	{
		projectileSpawn = Instantiate(projectilePrefab) as GameObject;

		//var launchPointPosition = GameObject.Find("Launch Point").transform.position;
		projectileSpawn.transform.position = GetMousePosition3D();
		projectileSpawn.GetComponent<Rigidbody>().isKinematic = true;
		//MouseDown.Invoke();
	}

	public void OnMouseUp() {
		Destroy(projectileSpawn);
	}

	public static Vector3 GetMousePosition3D() { 
		var mouseCoords2D = Input.mousePosition;
		mouseCoords2D.z = -Camera.main.transform.position.z;
		return Camera.main.ScreenToWorldPoint(mouseCoords2D);
	}
}
