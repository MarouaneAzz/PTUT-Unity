using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour {
    /*public Texture2D cursorTexture ;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;*/

    public Texture2D cursorImage;
    private Vector2 hotspot = new Vector2(16,16);
    private int cursorWidth = 32;
    private int cursorHeight = 32;
    // Use this for initialization
    void Start () {
        Cursor.visible = false;
        //Cursor.SetCursor(cursorImage, hotspot, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        //OnMouseEnter();
        //OnMouseExit();
       

    }
   /* void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
        void OnMouseEnter()
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }*/
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Input.mousePosition.x-16, Screen.height - Input.mousePosition.y-16, cursorWidth, cursorHeight), cursorImage);
    }


}
