using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Vector2 playerDirection;
    public Transform webTransform;
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
		UpdateWeb();
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

	void UpdateWeb() {
		webTransform.position = clickedPosition;
		webTransform.localScale = new Vector3(Vector3.Distance(clickedPosition, transform.position)/17, 0.5f, 0);
		Vector3 dir = transform.position - webTransform.position;
		float angle = Mathf.Atan2(dir.y, dir.x ) * Mathf.Rad2Deg;  
		webTransform.rotation = Quaternion.Euler( 0f, 0f, angle);
	}

	void GetMouseInput() {
		if(Input.GetMouseButtonUp(0)) {
			clickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			clicked = true;
		}
		if(Input.GetMouseButtonUp(1)) {
			clicked = false;
		}

	}


	//void CreateWeb() {
	//    //a patifaria acontece aqui, comente o return por sua conta e risco
	//    return;
	//    Debug.Log("Criando teia");
	//    Vector2 targetPosition = clickedPosition;
	//	  Vector2 playerPosition = transform.position;
	//    Vector2 webDir = (targetPosition - playerPosition).normalized;
	//    spiderWeb = Instantiate(pfSpiderWeb, playerPosition, Quaternion.identity);
	//    spiderWeb.eulerAngles = new Vector3(0, 0, Vector3.Angle(playerPosition, targetPosition));
	//    spiderWeb.GetComponent<SpriteRenderer>().size = new Vector2(
	//        Vector3.Distance(playerPosition, targetPosition),
	//        spiderWeb.GetComponent<SpriteRenderer>().size.y/2
	//        );
	//}
}
