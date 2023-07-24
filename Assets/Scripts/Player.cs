using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        var moveVector = new Vector3(horizontal, vertical, 0);

        rb.MovePosition(new Vector3((transform.position.x + moveVector.x * moveSpeed * Time.fixedDeltaTime), (transform.position.y + moveVector.y * moveSpeed * Time.fixedDeltaTime)));
    }
}

