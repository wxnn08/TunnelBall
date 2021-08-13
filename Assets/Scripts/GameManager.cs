using UnityEngine;

public class GameManager : MonoBehaviour {

	public int obstacleQuantity;
	public GameObject obstacle;
	public GameObject player;
	public GameObject end;

	void Start() {
		for(int i = 0; i < obstacleQuantity; i++) {
			Vector3 position = new Vector3(Random.Range(-80.0f, 80.0f), Random.Range(-50.0f, 50.0f), 0);
			GameObject obj = Instantiate(obstacle, position, Quaternion.identity);
			float size = Random.Range(2, 5);
			obj.transform.localScale = new Vector3(size, size, 0);
		}
	}

	void Update() {
	}
}
