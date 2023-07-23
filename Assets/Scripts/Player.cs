using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 20f;

    void Start()
    {
        
    }

    void Update()
    {        
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical")  * moveSpeed * Time.deltaTime;

        transform.Translate(horizontal, 0, 0);
        transform.Translate(0, vertical, 0);
    }
}
