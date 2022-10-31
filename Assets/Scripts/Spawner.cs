using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cubePrefab;
    private GameObject[] cubeList;

    void Start()
    {
        UpdateCubeList();
        StartCoroutine(nameof(Spawn));
    }

    IEnumerator Spawn()
    {
        CubeActivator();
        yield return new WaitForSeconds(DataManager.Instance.time);
        StartCoroutine(nameof(Spawn));
    }

    private void UpdateCubeList()
    {
        int n = transform.childCount;
        cubeList = new GameObject[n];
        for (int i = 0; i < n; i++)
        {
            cubeList[i] = transform.GetChild(i).gameObject;
        }
    }

    private void CubeActivator()
    {
        GameObject firstCube = transform.GetChild(0).gameObject;
        if (firstCube.activeSelf)
        {
            firstCube = Instantiate(cubePrefab, transform);
        }
        else
        {
            firstCube.SetActive(true);
        }
        firstCube.transform.SetAsLastSibling();
    }
}
