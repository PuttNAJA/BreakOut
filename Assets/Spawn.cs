using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject Ball;

    private int loop = 5;
    
    void Start()
    {
        
        StartCoroutine(SpawnLoop());
    }

    
    IEnumerator SpawnLoop()
    {
        while (true)
        {
            Instantiate(Ball, transform.position, transform.rotation);

            yield return new WaitForSeconds(loop);
        }

    }
    void Update()
    {
        
    }
}
