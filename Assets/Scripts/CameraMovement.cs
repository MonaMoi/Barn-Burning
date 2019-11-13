using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float speed = 10;

    // Update is called once per frame
    void Update()
    {
        float horizontal_movement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical_movement = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(horizontal_movement, 0, vertical_movement);
    }
}