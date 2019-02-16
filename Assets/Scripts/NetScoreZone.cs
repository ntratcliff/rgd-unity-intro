using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetScoreZone : MonoBehaviour
{
    /// <summary>
    /// The scoreboard object in the scene
    /// </summary>
    [Tooltip("The scoreboard object in the scene")]
    public Scoreboard Scoreboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // make sure the object is a basketball, and that it is moving down
        if (collider.CompareTag("Basketball") 
            && collider.GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            Debug.Log("Basketball entered the net!");

            // increment the score
            Scoreboard.Score++;
        }
    }
}
