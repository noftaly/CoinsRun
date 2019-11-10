using UnityEngine;
using System.Collections;

public class WaterManager : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

	void OnCollisionEnter (Collision obj) {
		if (obj.gameObject.name == "coin(Clone)") {
			PopCoin.currentCoin -= 1;
			Destroy (obj.gameObject);
		}

	}
}
