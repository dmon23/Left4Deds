using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float enemySpeed = 0.5f;

    [SerializeField] float destroyDelay = 0.5f;

    int health = 20;

    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {   


    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log(other);
    }

     private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Bullet") {
            Destroy(other.gameObject);

            int damage = other.gameObject.GetComponent<BulletScript>().bulletDamage;

            health -= damage;

            Debug.Log(health);

            if(health <= 0) {
                Destroy(gameObject);
            }

        }

    }
}
