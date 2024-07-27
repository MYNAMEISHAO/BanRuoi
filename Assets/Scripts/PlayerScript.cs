using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;
    Vector3 MousePos;
    Vector3 Direction;
    float speed;
    GameObject Currentbullet;
    float ShootingCoolDown = 0.5f;
    float currentTime = 0;
    GameObject BulletHolder;
    [SerializeField] Transform shootingPoint;
    void Start()
    {
        cam = Camera.main;
        speed = 5f;
        Currentbullet = Resources.Load<GameObject>("Bullet/BulletPlayer");
        BulletHolder = GameObject.Find("BulletPool");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Move();
            if (currentTime > ShootingCoolDown)
            {
                Shoot();
                currentTime = 0;
            }
            currentTime += Time.deltaTime;
        }
    }

    private void Move()
    {
        MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Direction = (MousePos - transform.position);
        Direction = new Vector3(Direction.x, Direction.y, 0).normalized;
        transform.position += Direction * speed * Time.deltaTime;
    }

    private void Shoot()
    {
        SimplePool.Spawn(Currentbullet,shootingPoint.position,Quaternion.identity,BulletHolder.transform);
    }

}
