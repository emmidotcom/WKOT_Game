using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    public Texture2D cursor;
    //Vector2 targetPos;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
    }

   // private void Update()
    //{
       // targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // transform.position = targetPos;
    //}
}
