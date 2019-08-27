using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // +++++++++++++++++the is Normal code went Using AWSD key+++++++++
    /* 
   public bool canMove = true;
public float moveSpeed;
   public float maxPos;

private void Update() {
    if(canMove)
    {
        Move();
    }   

}
     void Move()
     {
         float inputX = Input.GetAxis("Horizontal");

         transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

         float xPos = Mathf.Clamp(transform.position.x, -maxPos,maxPos);
     
          transform.position = new Vector3(xPos, transform.position.y,transform.position.z);
     }
     */
// and thisVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVdown there is using Button click to move______________-


     public  float MoveSpeed;
	Rigidbody2D rb;
	public float maxPos = 0;
	Vector3 position;


	void Update()
	{
		position = transform.position;
		position.x = Mathf.Clamp (position.x, -maxPos, maxPos);
		transform.position = position;
	}

	public void Awake()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	public void MoveLeft()
	{
		rb.velocity = new Vector2 (-MoveSpeed, 0);

	}
	public void MoveRight()
	{
		rb.velocity = new Vector2 (MoveSpeed, 0);

	}
	public void SetVelocityZero()
	{
		rb.velocity = Vector2.zero;
	}

}
