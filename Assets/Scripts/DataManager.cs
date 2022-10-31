using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }
    public float time = 1f;
    public float speed = 0.1f;
    public float distance = 100f;

    void Awake()
    {
        Instance = this;
    }
}
