using UnityEngine;

public class GameManager : MonoBehaviour {

	public int obstacleQuantity;
	public GameObject obstacle;

	void Start() {
		for(int i = 0; i < obstacleQuantity; i++) {
			Vector3 position = new Vector3(Random.Range(-80.0f, 80.0f), Random.Range(-50.0f, 50.0f), 0);
			Instantiate(obstacle, position, Quaternion.identity);
		}
	}

	void Update() {

	}
}
