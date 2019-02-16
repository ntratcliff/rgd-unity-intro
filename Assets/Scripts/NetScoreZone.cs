using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetScoreZone : MonoBehaviour
{
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
        // make sure the object is a basketball, and it's moving down!
        if (collider.CompareTag("Basketball") 
            && collider.GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            Debug.Log("Basketball entered the net!");
            
        }
    }
}
