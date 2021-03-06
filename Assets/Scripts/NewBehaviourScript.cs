using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float movementSpeed = 3.0f;
    Vector3 movement = new Vector3();
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()  
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();
        movement *= movementSpeed * Time.deltaTime;
        rigidbody.MovePosition(transform.position + movement);
    }
}
