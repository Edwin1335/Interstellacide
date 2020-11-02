using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfinerMovement : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(moveSpeed, 0, 0);
    }
}
