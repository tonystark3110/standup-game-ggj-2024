using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class LookAtObject : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(target.position);
    }


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.position);
    }
}
