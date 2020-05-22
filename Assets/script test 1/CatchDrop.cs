using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchDrop : MonoBehaviour
{
    public Transform onhand;

    void Update()
    {
        OnMouseDown();
    }

    void OnMouseDown()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
    }

}