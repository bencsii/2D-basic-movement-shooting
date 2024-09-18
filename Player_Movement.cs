using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    [SerializeField]
    private float speed = 2;

    [SerializeField]
    private GameObject bullet;

    //basic player controller x, y axis
    // site used: https://dev.to/genomagames/how-to-move-2d-objects-in-unity-573n
    private void Update()

    {
        //start of shooting part


        if (Input.GetButtonDown("Fire1")) 
        {
            Vector3 playerPosition = transform.position;
            Instantiate(bullet, playerPosition, Quaternion.identity);
        }


       //end of shooting part
        // https://docs.unity3d.com/ScriptReference/Input.GetAxisRaw.html // references
        float rawHorizontalAxis = Input.GetAxisRaw("Horizontal");

        // https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Vector3-zero.html
        Vector3 direction = Vector3.zero;
        direction.x = rawHorizontalAxis;

        // https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Time-deltaTime.html
        float timeSinceLastFrame = Time.deltaTime;

        Vector3 translation = direction * speed * timeSinceLastFrame;


        // https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Transform.Translate.html
        transform.Translate(
          translation
        );
    }
}
