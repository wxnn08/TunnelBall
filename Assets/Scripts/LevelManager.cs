using UnityEngine;

public class LevelManager : MonoBehaviour {

	public int obstacleQuantity;
	public GameObject obstacle;
	public GameObject player;
	public GameObject end;
	public GameObject begin;

	void Start() {
		SetupMap();

		for(int i = 0; i < obstacleQuantity; i++) {
			Vector3 position = new Vector3(Random.Range(-80.0f, 80.0f), Random.Range(-50.0f, 50.0f), 0);
			GameObject obj = Instantiate(obstacle, position, Quaternion.identity);
			float size = Random.Range(2, 5);
			obj.transform.localScale = new Vector3(size, size, 0);
		}
	}

	void SetupMap() {
		GameObject map1, map2, map3;
		map1 = GameObject.Find("Map1");
		map2 = GameObject.Find("Map2");
		map3 = GameObject.Find("Map3");

		int levelSelected = LevelSetup.Instance.levelSelected;
		switch(levelSelected) {
			case 1:
				map1.SetActive(true);
				map2.SetActive(false);
				map3.SetActive(false);
				break;
			case 2:
				map1.SetActive(false);
				map2.SetActive(true);
				map3.SetActive(false);
				break;
			case 3:
				map1.SetActive(false);
				map2.SetActive(false);
				map3.SetActive(true);
				break;
		}

	}


	void Update() {
	}
}
