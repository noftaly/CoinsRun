using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour {
	Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score : " + PlayerManager.score + "/" + DoorsManager.scoreDoors; 
	}
}
