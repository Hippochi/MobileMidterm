//Background Controller
// Alex Dine
//101264627
//Oct 20th 2021
// makes the bullets control properly
//revised to work in portrait


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float verticalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }
    //moves the bullet
    private void _Move()
    {
        transform.position += new Vector3(verticalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }
    //checks for the bullet leaving the playspace
    private void _CheckBounds()
    {
        if (transform.position.x > verticalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }
    //checks for collision
    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }
    //unused
    public int ApplyDamage()
    {
        return damage;
    }
}
