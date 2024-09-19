using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_logic : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D rb;
    private Transform CurrentPoint;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CurrentPoint = PointB.transform;

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = CurrentPoint.position;
        if (CurrentPoint == PointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2 (-speed, 0);   
        }

        if (Vector2.Distance(transform.position,CurrentPoint.position) < 0.5f && CurrentPoint == PointB.transform)
        {
            CurrentPoint = PointA.transform;

        }

        if (Vector2.Distance(transform.position, CurrentPoint.position) < 0.5f && CurrentPoint ==PointA.transform)
        {
            CurrentPoint = PointB.transform;

        }
    }
}
