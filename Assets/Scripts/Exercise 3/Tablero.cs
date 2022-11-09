using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour
{
    public int movement = 120;

    public int borderY = 0;

    public int borderX = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (borderY < 2)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + movement, 0);
                borderY++;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (borderX > -2)
            {
                gameObject.transform.position = new Vector3(transform.position.x - movement, transform.position.y, 0);
                borderX--;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (borderY > -2)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - movement, 0);
                borderY--;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (borderX < 2)
            {
                gameObject.transform.position = new Vector3(transform.position.x + movement, transform.position.y, 0);
                borderX++;
            }
        }
    }
}
