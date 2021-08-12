using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionPoint : MonoBehaviour {
	private void wallCollision() {
		SceneManager.LoadScene("EndScene");
	}

	//private void OnTriggerEnter2D(Collider2D other) {
	private void OnTriggerExit2D(Collider2D other) {
		if(other.CompareTag("Path")) {
			wallCollision();
		}
	}
}
