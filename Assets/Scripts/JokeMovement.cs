using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JokeMovement : MonoBehaviour
{
    public Vector3 trajectory = Vector3.zero;
    public float speed = 0f;

    public float killDistance = Mathf.Infinity;
    public Vector3 originPoint = Vector3.zero;

    public JokeButtonManager manager;

    private RectTransform rect;

    void Start() {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        rect.transform.position += trajectory * speed * Time.deltaTime;
        //Debug.Log("Position: " + rect.transform.position);
        //Debug.Log("Distance: " + Vector3.Distance(rect.transform.position, Vector3.zero));
        if (Vector3.Distance(rect.transform.position, originPoint) > killDistance) {
            manager.createRandomJokeButton();
            //Debug.Log("Destroyed");
            Destroy(gameObject);
        }
    }
}
