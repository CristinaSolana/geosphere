using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour {

	private GameObject target;
    private float speed = 10.0f;
    private Vector3 point;
    private float moveX;
    private float moveY;

    void Start () {

		target = GameObject.Find("GeoSphere");
        point = target.transform.position;
        transform.LookAt(point);

    }
    
    void Update () {

		if (Input.GetMouseButton(0)) {

            moveX = Input.GetAxis("Mouse X");
            moveY = Input.GetAxis("Mouse Y");

            Vector3 movement = new Vector3(0f,moveX,moveY);
            
            transform.RotateAround (point,movement,20 * Time.deltaTime * speed);

        }

    }

}
