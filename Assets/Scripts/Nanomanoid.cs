using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nanomanoid : MonoBehaviour
{
    public Sprite mainSprite;
    public float movementSpeed;
    public SpriteRenderer spriteRenderer;
    public void Movement()
    
      
    {
        spriteRenderer.sprite = mainSprite;
        if (Input.GetKey(KeyCode.W)) 

        {
            movementSpeed = 5;
            Vector2 newPosition; // nowa pozycja
            
            newPosition.x = transform.position.x;
            newPosition.y = transform.position.y + movementSpeed * Time.deltaTime;
            transform.position = newPosition;
            
            


        }
        if (Input.GetKey(KeyCode.S))
        {
            movementSpeed = 5;
            Vector2 newPosition;
            newPosition.x = transform.position.x;
            newPosition.y = transform.position.y - movementSpeed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementSpeed = 5;
            Vector2 newPosition;
            newPosition.x = transform.position.x - movementSpeed * Time.deltaTime; ;
            newPosition.y = transform.position.y;
            transform.position = newPosition;


        }
        if (Input.GetKey(KeyCode.D))
        {
            movementSpeed = 5;
            Vector2 newPosition;
            newPosition.x = transform.position.x + movementSpeed * Time.deltaTime;
            newPosition.y = transform.position.y;
            transform.position = newPosition;


        }
    }
    }


