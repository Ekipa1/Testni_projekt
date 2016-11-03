using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

	#pragma strict

	public KeyCode Gor;
	public KeyCode Dol;
	public KeyCode Levo;
	public KeyCode Desno;
	private float speed = 2.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			
			if (Input.GetKey (Levo) && transform.position.x < 6.2) {
				transform.position += Vector3.right * speed * Time.deltaTime;
			transform.Rotate(0, 0, -3);
			}
			if (Input.GetKey (Desno) && transform.position.x > -6.19) {
				transform.position += Vector3.left * speed * Time.deltaTime;
			transform.Rotate(0, 0, 3);

			}
			if (Input.GetKey (Dol) && transform.position.z < 3.71) {
				transform.position += Vector3.forward * speed * Time.deltaTime;
			transform.Rotate(3, 0, 0);
			}
			if (Input.GetKey (Gor) && transform.position.z > -3.76) {
				transform.position += Vector3.back * speed * Time.deltaTime;
			transform.Rotate(-3, 0, 0);
			}
	}

}
