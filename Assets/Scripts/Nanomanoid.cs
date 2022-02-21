using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nanomanoid : MonoBehaviour
{
    public float movementSpeed;

    public Sprite mainSprite;

    public SpriteRenderer spriteRenderer;

    private void Update()
    {
        Movement();
    }
    public void Movement()
    {
       
        Vector2 newPosition; // nowa pozycja
        if (Input.GetKey(KeyCode.W))
        {
            newPosition.x = transform.position.x;
            newPosition.y = transform.position.y + movementSpeed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPosition.x = transform.position.x;
            newPosition.y = transform.position.y - movementSpeed * Time.deltaTime;
            transform.position = newPosition; spriteRenderer.sprite = mainSprite;
        }
        if (Input.GetKey(KeyCode.A))
        {
            newPosition.x = transform.position.x - movementSpeed * Time.deltaTime; ;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newPosition.x = transform.position.x + movementSpeed * Time.deltaTime;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }
    }
}