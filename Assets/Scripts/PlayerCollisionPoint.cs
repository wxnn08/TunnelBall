using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionPoint : MonoBehaviour {
	private void endGame() {
		SceneManager.LoadScene("EndScene");
	}


	//private void OnTriggerEnter2D(Collider2D other) {
	private void OnTriggerExit2D(Collider2D other) {
		if(other.CompareTag("Path")) {
			endGame();
		}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Obstacle")) {
			endGame();
		}
	}
}
