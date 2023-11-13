using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] FixedJoystick joystick;
    [SerializeField] float moveSpeed;

    float horizontalInput, verticalInput;

    public int score = 0;
    public int winScore;


    private void FixedUpdate()
    {
        horizontalInput = joystick.Horizontal * moveSpeed;
        verticalInput = joystick.Vertical * moveSpeed;

        transform.Translate(horizontalInput, verticalInput, 0);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Carrot")
        {
            score++;
            Destroy(collision.gameObject);

            if(score >= winScore)
            {
                moveSpeed = 0;
            }
        }
    }
}
