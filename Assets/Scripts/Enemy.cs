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
        // solution 1
        // float x_pos = (player.transform.position[0] > transform.position[0] ? 1 : -1) * enemySpeed * Time.deltaTime;
        // float y_pos = (player.transform.position[1] > transform.position[1] ? 1 : -1) * enemySpeed * Time.deltaTime;
        // transform.position = transform.position + new Vector3 (x_pos, y_pos, 0);

        //solution 2
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemySpeed * Time.deltaTime);


    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log(other);
        // health -= 5;
        // Debug.Log(gameObject);

        // if(health <= 5) 
        // {

        // }
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
