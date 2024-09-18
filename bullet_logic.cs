using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_logic : MonoBehaviour
{
    [SerializeField]

    private float speed = 5;

    void Update()
    {
        Vector3 direction = Vector3.up;

        float TimeSinceLastFrame = Time.deltaTime;
        Vector3 translation = direction * speed * TimeSinceLastFrame;
        

        transform.Translate(translation);
    }
}
