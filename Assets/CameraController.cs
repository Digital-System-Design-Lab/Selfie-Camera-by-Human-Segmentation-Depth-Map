using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    GameObject camParent;

	void Start () {
        camParent = new GameObject("CamParent");
        camParent.transform.position = this.transform.position;
        this.transform.parent = camParent.transform;
        Input.gyro.enabled = true;
	}
	
	
	void Update () {
        camParent.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y *8, 0);
        if(-0.12 < this.transform.rotation.x && this.transform.rotation.x<0.15)
        {
                this.transform.Rotate(Input.gyro.rotationRateUnbiased.x *4, 0, 0);
        }else{
                Debug.Log(this.transform.rotation.x);
        }

	}
}