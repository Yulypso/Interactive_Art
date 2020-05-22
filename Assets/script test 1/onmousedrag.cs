using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onmousedrag : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        OnMouseDrag();
	}


    public float horizontalSpeed = 2;
    public float verticalSpeed = 2;

    void OnMouseDrag()
    {
        var h = horizontalSpeed * Input.GetAxis("Mouse X");
        transform.Translate(h, 0, 0);

        var j = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Translate(0, j, 0);
    }
}