using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Vector2 playerDirection;
	Vector2 clickedPosition;
	public float speed;
	bool clicked;
	
    void Start() {
		playerDirection = new Vector2(1, 0);
		clicked = false;
    }

    // Update is called once per frame
    void Update() {
		GetMouseInput();
		UpdateCameraPosition();
		UpdatePlayerVelocity();
	}

	void UpdateCameraPosition() {
		Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
	}

	void UpdatePlayerVelocity() {
		Vector2 playerPosition = transform.position;

		if(clicked) {
			Vector2 c = (clickedPosition - playerPosition).normalized;
			Vector2 p = Vector2.Perpendicular(c);
			float proj = Vector2.Dot(playerDirection, p);
			playerDirection = (proj < 0 ? -1 : 1) * p.normalized;

		}

		playerPosition += playerDirection * speed * Time.deltaTime;
		transform.position = playerPosition;
	}

	void GetMouseInput() {
		if(Input.GetMouseButton(0)) {
			clickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			clicked = true;
		}
		if(Input.GetMouseButtonUp(1)) {
			clicked = false;
		}

	}
}