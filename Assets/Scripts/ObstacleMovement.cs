using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

	Vector3 velocity;

    void Start() {
        velocity = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0).normalized;
    }

    void Update() {
        transform.position += velocity * Time.deltaTime;
    }
}
