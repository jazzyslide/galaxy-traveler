using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControl : MonoBehaviour {

	//スピード
	float X_Speed = 1.2f;
	float Y_Speed = 1.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//入力を取得
		float key_x = Input.GetAxis ("Horizontal");
		float key_y = Input.GetAxis ("Vertical");

		//キー操作
		//上を押した時
		if (Input.GetKey ("up")) {
			//画面上からはみ出ないところまで
			if (transform.localPosition.y < 20) {	
				transform.Translate (0, key_y * Y_Speed, 0);
			}
		}
		//下を押した時
		if (Input.GetKey ("down")) {
			//画面上からはみ出ないところまで
			if (transform.localPosition.y > -20) {
				transform.Translate (0, key_y * Y_Speed, 0);
			}
		}
		//左を押した時
		if (Input.GetKey ("left")) {
			//画面上からはみ出ないところまで
			if (transform.localPosition.x > -30) {
				transform.Translate (key_x * X_Speed, 0, 0);
			}
		}
		//右を押した時
		if (Input.GetKey ("right")) {
			//画面上からはみ出ないところまで
			if (transform.localPosition.x < 30) {
				transform.Translate (key_x * X_Speed, 0, 0);
			}
		}
	}

	//何かが衝突した時自分と相手を両方消す
	void OnCollisionEnter(Collision collision){
		Destroy(collision.gameObject);
		Destroy(this.gameObject);
	}
}
