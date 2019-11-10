using UnityEngine;
using UnityEngine.UI;

public class UIGameManager : MonoBehaviour {
	Text UIGame;

	// Use this for initialization
	void Start () {
		UIGame = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
        switch (PlayerManager.currentState)
        {
            case PlayerManager.State.NONE:
                UIGame.text = "";
                break;
            case PlayerManager.State.WIN:
                UIGame.text = "You win :) GG!";
                break;
            case PlayerManager.State.LOSE:
                UIGame.text = "You Lose :( Try again!";
                break;
        }
    }
}
