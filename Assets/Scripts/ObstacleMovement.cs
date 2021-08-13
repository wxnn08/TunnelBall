using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

	public Vector3 velocity;

    void Start() {
        velocity = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
		velocity.Normalize();
    }

    void Update() {
        transform.position += 2 * Time.deltaTime * velocity;
    }

	private void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("VerticalWall")) {
			velocity.x *= -1;
		}
		if(other.CompareTag("HorizontalWall")) {
			velocity.y *= -1;
		}
	}
}
