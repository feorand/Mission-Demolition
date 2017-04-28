using UnityEngine;
using UnityEngine.Events;

public class ProjectileSpawner : MonoBehaviour {
	public GameObject projectilePrefab;

	private GameObject projectileSpawn;

	public void OnMouseDown()
	{
		projectileSpawn = Instantiate(projectilePrefab) as GameObject;
		projectileSpawn.transform.position = PlayerStatus.MousePosition3D;
		projectileSpawn.GetComponent<Rigidbody>().isKinematic = true;
	}

	public void OnMouseUp() {
		Destroy(projectileSpawn);
	}
}
