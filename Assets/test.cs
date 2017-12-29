using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour {
 	
	public GameObject target;
    private float speedMod = 5.0f;
    private Vector3 point;
   
    void Start () {

		target = GameObject.Find("Sphere");
        point = target.transform.position;
        transform.LookAt(point);

    }
   
    void Update () {

		// if (Input.GetMouseButton(0))
        //     transform.RotateAround (point,new Vector3(0.0f,1.0f,0.0f),20 * Time.deltaTime * speedMod);

		if (Input.GetMouseButtonDown(0))
			Debug.Log(Input.mousePosition);

		if (Input.GetMouseButtonUp(0))
			Debug.Log(Input.mousePosition);

		if (Input.GetKey("up"))
            transform.RotateAround (point,new Vector3(0.0f,0.0f,-1.0f),20 * Time.deltaTime * speedMod);
        
        if (Input.GetKey("down"))
            transform.RotateAround (point,new Vector3(0.0f,0.0f,1.0f),20 * Time.deltaTime * speedMod);

		if (Input.GetKey("left"))
            transform.RotateAround (point,new Vector3(0.0f,-1.0f,0.0f),20 * Time.deltaTime * speedMod);
        
        if (Input.GetKey("right"))
            transform.RotateAround (point,new Vector3(0.0f,1.0f,0.0f),20 * Time.deltaTime * speedMod);

    }

}
