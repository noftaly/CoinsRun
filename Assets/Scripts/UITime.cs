using UnityEngine;
using UnityEngine.UI;

public class UITime : MonoBehaviour {
	Text timeText;
	int lastSecond;

	public float currentTime = 60.0f;

	// Use this for initialization
	void Start () {
		timeText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (currentTime < 0){
			timeText.text = "Time : 0";
		    PlayerManager.currentState = PlayerManager.State.LOSE;
		} else {
			timeText.text = "Time : " + (int) currentTime;
			if (PlayerManager.score == 8 && lastSecond == 0) {
				currentTime -= 15.0f;
				lastSecond = 1;
			}
			currentTime -= Time.deltaTime;
		}
	}
}
