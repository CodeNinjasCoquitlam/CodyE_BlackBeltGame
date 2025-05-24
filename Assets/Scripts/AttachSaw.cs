using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachSaw : MonoBehaviour
{
    public GameObject player;
    public GameObject ball;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Saw")
        {
            ball.transform.parent = player.transform; // Set the ball's parent to the player
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
