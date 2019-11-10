using UnityEngine;

public class DoorsManager : MonoBehaviour {
	public int coinsOpen = 2;
	public static int scoreDoors;

	// Use this for initialization
	void Start () {
		scoreDoors = coinsOpen;
	}

	// Update is called once per frame
	void Update () {
		if (PlayerManager.score == coinsOpen) {
			Destroy (gameObject); // Destroy Door
		}
	}
}
