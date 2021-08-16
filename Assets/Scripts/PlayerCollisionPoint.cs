using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionPoint : MonoBehaviour {
	private void LoseScene(){
		SceneManager.LoadScene("LoseScene");
	}

	private void WinScene(){
		SceneManager.LoadScene("WinScene");
	}


	//private void OnTriggerEnter2D(Collider2D other) {
	private void OnTriggerExit2D(Collider2D other) {
		if(other.CompareTag("Path")) {
			LoseScene();
		}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Obstacle")) {
			LoseScene();
		}

		if(other.CompareTag("End")) {
			WinScene();
		}
	}
}
