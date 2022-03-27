using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{

    public float speed;

    public int destroyTime;

    private void Start()
    {
        Destroy(gameObject, destroyTime);
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }


}
