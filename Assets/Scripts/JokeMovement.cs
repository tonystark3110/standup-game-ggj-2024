using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JokeMovement : MonoBehaviour
{
    public Vector3 trajectory = Vector3.zero;
    public float speed = 0f;

    private RectTransform rect;

    void Start() {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        rect.transform.position += trajectory * speed * Time.deltaTime;
    }
}
