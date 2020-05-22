using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Debug.Log example
//
// Create three cubes. Place them around the world origin.
// If a cube is clicked use Debug.Log to announce it. Use
// Debug.Log with two arguments. Argument two allows the
// cube to be automatically selected in the hierarchy when
// the console message is clicked.
//
// Add this script to an empty GameObject.

public class testscript2 : MonoBehaviour
{
    private GameObject[] cubes;

    void Awake()
    {
        // Create three cubes and place them close to the world space center.
        cubes = new GameObject[3];
        float f = 25.0f;
        float p = -2.0f;
        float[] z = new float[] {0.5f, 0.0f, 0.5f};

        for (int i = 0; i < 3; i++)
        {
            // Position and rotate each cube.
            cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubes[i].name = "Cube" + (i + 1).ToString();
            cubes[i].transform.Rotate(0.0f, f, 0.0f);
            cubes[i].transform.position = new Vector3(p, 0.0f, z[i]);
            f -= 25.0f;
            p = p + 2.0f;
        }

        // Position and rotate the camera to view all three cubes.
        Camera.main.transform.position = new Vector3(3.0f, 1.5f, 3.0f);
        Camera.main.transform.localEulerAngles = new Vector3(25.0f, -140.0f, 0.0f);
    }

    void Update()
    {
        // Process a mouse button click.
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Visit each cube and determine if it has been clicked.
                for (int i = 0; i < 3; i++)
                {
                    if (hit.collider.gameObject == cubes[i])
                    {
                        // This cube was clicked.
                        Debug.Log("Hit " + cubes[i].name, cubes[i]);
                    }
                }
            }
        }
    }
}