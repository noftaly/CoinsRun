using UnityEngine;

public class PlayerManager : MonoBehaviour {
	public static int score;

	public enum State {
		NONE = 0,
		WIN,
		LOSE
	};

	public static State currentState;
	public AudioClip clip;
	AudioSource sound;

	// Use this for initialization
	void Start () {
		score = 0; // Init score
		currentState = State.NONE;
		sound = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {}

	void OnCollisionEnter(Collision obj){
        switch (obj.gameObject.name)
        {
            case "coin(Clone)":
                sound.PlayOneShot(clip);
                score += 1;
                Destroy(obj.gameObject);
                break;
            case "Water":
                currentState = State.LOSE;
                break;
            case "Rune":
                currentState = State.WIN;
                break;
        }
    }
}
