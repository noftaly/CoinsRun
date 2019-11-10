using UnityEngine;

public class RotateManager : MonoBehaviour {
	public Vector3 axes;
	public float speed = 5.0f;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (axes, speed);
	}
}
