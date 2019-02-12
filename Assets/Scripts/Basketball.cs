using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    /// <summary>
    /// The force multiplier used when the player throws the ball
    /// </summary>
    [Tooltip("The force multiplier used when the player throws the ball")]
    public float ThrowForce = 1;

    /// <summary>
    /// True when the player started holding down the mouse over the ball, 
    /// false once the mouse is released
    /// </summary>
    //private bool mouseDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse down!");
        //mouseDown = true;
    }

    private void OnMouseUp()
    {
        Debug.Log("Mouse up!");

        // throw ball
        // get mouse position in screen coordinates
        Vector2 mousePos = Input.mousePosition;

        // convert screen coordinates to world coordinates
        Vector2 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePos);

        // calculate vector from mouse to ball (fromToVec = to - from)
        Vector2 mouseToBall = (Vector2)transform.position - mousePosWorld;

        // apply force to ball rigidbody
        GetComponent<Rigidbody2D>().AddForce(mouseToBall * ThrowForce, ForceMode2D.Impulse);

        //mouseDown = false;
    }
}
