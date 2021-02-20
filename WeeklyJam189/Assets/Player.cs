using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float smoothTime = .125f; 

    Vector2 moveDirection;
    Vector2 smoothSpeed;
    Rigidbody2D rb;

    void OnDisable(){  }
    void OnEnable(){  }
    void Awake(){  }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.AddForce(moveDirection * moveSpeed, ForceMode2D.Force);
    }
}
