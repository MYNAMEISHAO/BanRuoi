using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float direction = 1;
    BoxCollider2D EnemyBox;
    float speed = 2;
   
    // Start is called before the first frame update
    void Start()
    {
        EnemyBox = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += transform.right * speed * direction * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boundary"))
        {
            direction*=-1;
        }
    }
}
