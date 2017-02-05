using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiller : MonoBehaviour {

	float zRotation = 0;
	int dir = 45;
	
	void start(){
		zRotation = transform.eulerAngles.z;
	}
	
	void Update () {
		transform.Rotate (new Vector3 (0, 0, dir) * Time.deltaTime);
		zRotation = transform.eulerAngles.z;
		if(zRotation > 15){
			dir = -45;
		}
		else if(zRotation < 1){
			dir = 45;
		}        
    }
}
