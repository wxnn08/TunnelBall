using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour {

	public void SelectLevel() {
		SceneManager.LoadScene("LevelSelection");
	}

	public void PlayAgain() {
		SceneManager.LoadScene("GameplayScene");
	}
}
