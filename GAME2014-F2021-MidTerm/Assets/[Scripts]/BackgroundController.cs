//Background Controller
// Alex Dine
//101264627
//Oct 20th 2021
// makes the background flow seamlessly across the screen
//revised to work in portrait




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float HorizontalSpeed;
    public float HorizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }
    //resets the background to original pos
    private void _Reset()
    {
        transform.position = new Vector3(HorizontalBoundary, 0.0f);
    }
    // moves the background
    private void _Move()
    {
        transform.position -= new Vector3(HorizontalSpeed, 0.0f) * Time.deltaTime;
    }
    //checks for when the background is ready to loop
    private void _CheckBounds()
    {
        if (transform.position.x <= -HorizontalBoundary)
        {
            _Reset();
        }
    }
}
