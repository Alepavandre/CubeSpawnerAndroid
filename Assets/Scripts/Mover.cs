using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 position;

    private void Start()
    {
        position = transform.position;
    }

    void Update()
    {
        transform.position += Vector3.forward * DataManager.Instance.speed;
        if (transform.position.z >= DataManager.Instance.distance)
        {
            transform.position = position;
            gameObject.SetActive(false);
        }
    }
}
