using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street : MonoBehaviour
{
    [SerializeField] Transform initialPositionTransform;
    [SerializeField] Transform finalPositionTransform;
    [SerializeField] float speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.down * speed * Time.fixedDeltaTime);
        if(transform.position.y <= finalPositionTransform.position.y)
        {
            transform.position = initialPositionTransform.position;
        }
    }
}
