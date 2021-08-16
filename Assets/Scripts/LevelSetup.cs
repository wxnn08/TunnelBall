using UnityEngine;

public class LevelSetup : MonoBehaviour {
	private static LevelSetup _instance;
	public static LevelSetup Instance { get { return _instance; } }

	public int levelSelected = -1;
	public Vector3 beginPosition = new Vector3(0, 0, 0);

	private void Awake() {
		if (_instance != null && _instance != this)
		{
			Destroy(this.gameObject);
		} else {
			_instance = this;
		}
	}
}
