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
    /// The attached Rigidbody2D component
    /// </summary>
    new private Rigidbody2D rigidbody;

    // Awake is called before Start and only once ever
    private void Awake()
    {
        // get a reference to the attached rigidbody
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update, every time the object is activated
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Called when the left mouse button is pressed over a collider
    private void OnMouseDown()
    {
        Debug.Log("Mouse down!");

        // freeze ball and reset velocity
        rigidbody.simulated = false;
        rigidbody.velocity = Vector2.zero;
    }

    // Called when the left mouse button is released
    // after it has been pressed while over a collider
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
        rigidbody.simulated = true;
        rigidbody.AddForce(mouseToBall * ThrowForce, ForceMode2D.Impulse);
    }
}
