using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public Texture2D MouseCursor;

    private void Start()
    {
        //Sets the mouse cursor origin to its center (the default position is the sprites upper left corner)
        Vector2 cursorOffset = new Vector2(MouseCursor.width / 2, MouseCursor.height / 2);

        //Sets the dafualt OS cursor to the one we established above
        Cursor.SetCursor(MouseCursor, cursorOffset, CursorMode.Auto);
    }

}
