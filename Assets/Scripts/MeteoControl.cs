using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoControl : MonoBehaviour {

	//スピード
	float Z_speed = 0.7f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//回転させる
		transform.Rotate (new Vector3 (0, 0, transform.localRotation.z + Random.Range (0, 1.0f)));

		//逆向き（spaceshipに向かって）に移動させる
		transform.Translate (0, 0, -1 * Z_speed);

		//カメラの近くまで来たら消える
		if (transform.localPosition.z < -15) {
			Destroy (this.gameObject);
		}
	}
}
