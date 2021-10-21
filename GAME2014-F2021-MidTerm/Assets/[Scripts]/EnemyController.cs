//Enemy Controller
// Alex Dine
//101264627
//Oct 20th 2021
//controls enemy behaviour
//revised to work in portrait


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }
    // moves enemies
    private void _Move()
    {
        transform.position += new Vector3(0.0f, horizontalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check top boundary
        if (transform.position.y >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        // check bottom boundary
        if (transform.position.y <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}
