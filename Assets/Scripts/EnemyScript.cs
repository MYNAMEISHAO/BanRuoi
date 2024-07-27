using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject bullet;
    float ShootingCoolDown = 0.5f;
    float currentTime = 0;
    [SerializeField] GameObject ShootPos;
    void Start()
    {
        bullet = Resources.Load<GameObject>("Bullet/BulletEnemy");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > ShootingCoolDown)
        {
            Shoot();
            currentTime = 0;
        }
        currentTime += Time.deltaTime;
    }

    private void Entrance()
    {

    }

    private void Move()
    {
        
    }
    private void Shoot()
    {
        SimplePool.Spawn(bullet, ShootPos.transform.position, Quaternion.identity);
    }
}
