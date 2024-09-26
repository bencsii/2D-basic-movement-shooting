using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TopDownMovement : MonoBehaviour
{
    
    public float movementSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection2;
    public GameObject bullet;


    private void Start()
    {
        shooting();
    }

    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        Move();
        
    }

    void ProcessInputs()
    {
        float MoveX = Input.GetAxisRaw("Horizontal");
        float MoveY = Input.GetAxisRaw("Vertical");
        moveDirection2 = new Vector2(MoveX, MoveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection2.x * movementSpeed, moveDirection2.y * movementSpeed);
    }

    void shooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 playerPosition = transform.position;
            Instantiate(bullet, playerPosition, Quaternion.identity);
        }
    }
}
