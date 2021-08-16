using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour {

	public void Level1() {
		LevelSetup.Instance.levelSelected = 1;
		LevelSetup.Instance.beginPosition = new Vector3(-57.18f, -7.31f, 0f);
		LoadGameplayScene();
	}

	public void Level2() {
		LevelSetup.Instance.levelSelected = 2;
		LevelSetup.Instance.beginPosition = new Vector3(-57.18f, -7.31f, 0f);
		LoadGameplayScene();
	}

	public void Level3() {
		LevelSetup.Instance.levelSelected = 3;
		LevelSetup.Instance.beginPosition = new Vector3(-56.14f, -25.88f, 0f);
		LoadGameplayScene();
	}

	public void LoadGameplayScene() {
		SceneManager.LoadScene("GameplayScene");
	}
}
