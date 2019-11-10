using UnityEngine;

public class PopCoin : MonoBehaviour {
	public int width; // Map width
	public int depth; // Map depth
	public GameObject coin = null;
	public int maxCoin = 10;
	public static int currentCoin;
	Vector3 popZone; // Object defining the 3D pop zone
	System.Random rnd;

	// Use this for initialization
	void Start () {
		currentCoin = 0;
		popZone = new Vector3 (10, 250, 10);
		rnd = new System.Random ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentCoin < maxCoin) {
			currentCoin += 1;
			popZone.x = rnd.Next () % width;
			popZone.z = rnd.Next () % depth;
			if (coin != null) {
				Instantiate (coin, popZone, coin.transform.rotation);
			}
		}
	}
}
