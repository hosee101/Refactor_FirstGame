using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClimbRope : MonoBehaviour
{
    public Rigidbody2D rb;
    private float ClimbController;
    public int ClimbSpeed=5;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.transform.CompareTag("Rope"))
        {

            if ((Input.GetKey(PlayerMove.currentKey[0]) || Input.GetKey(PlayerMove.currentKey[2])))
            {
                if(Input.GetKey(PlayerMove.currentKey[0])){ ClimbController = 1; }
                else if (Input.GetKey(PlayerMove.currentKey[2])) { ClimbController = -1; }
                    rb.velocity = new Vector2(0, ClimbSpeed * ClimbController);
            }
        }
    }
    
}
