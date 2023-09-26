using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;

    Controls controls;

    Rigidbody2D rb;

    private void Awake()
    {
        controls = new Controls();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void FixedUpdate()
    {
        float input = controls.Car.Move.ReadValue<float>();
        rb.velocity = new Vector2(input * speed * Time.fixedDeltaTime, 0);
    }
}
