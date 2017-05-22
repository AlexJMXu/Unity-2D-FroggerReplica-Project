using UnityEngine;

public class CarSpawner : MonoBehaviour {

	public float spawnDelay = 0.3f;

	private float nextTimeToSpawn = 0f;

	public Transform[] spawnPoints;

	public GameObject car;

	void Update() {
		if (nextTimeToSpawn <= Time.time) {
			SpawnCar();
			nextTimeToSpawn = Time.time + spawnDelay;
		}

	}

	void SpawnCar() {
		Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

		GameObject go = (GameObject) Instantiate(car, spawnPoint.position, spawnPoint.rotation);
		Destroy(go, 3f);
	}

}
