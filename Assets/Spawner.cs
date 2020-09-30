using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] groups;

    void SpawnNext()
    {
        int rand = Random.Range(0, groups.Length);

        Instantiate(groups[rand], transform.position, Quaternion.identity);
    }

    void Start()
    {
        SpawnNext();
    }
}
