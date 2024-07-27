using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletScripts : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private float timeAlive = 5;
    internal float currentTimeAlive;
    [SerializeField] float direction = 1;
    //private int idBullet;

    // Update is called once per frame
    void Update()
    {
        currentTimeAlive += Time.deltaTime;
        transform.position += transform.up * direction * Time.deltaTime * speed;

        if (currentTimeAlive >= timeAlive)
        {
            currentTimeAlive = 0;
            SimplePool.Despawn(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SimplePool.Despawn(gameObject);
            Debug.Log("Hit");
            collision.gameObject.SetActive(false);
        }
    }
}
