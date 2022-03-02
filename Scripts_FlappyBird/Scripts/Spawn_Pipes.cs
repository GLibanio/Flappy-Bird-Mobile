using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Pipes : MonoBehaviour
{
    public GameObject pipe;
    public float height;
    public float MaxTime;

    private float timer = 0f;
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        if(timer > MaxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 20f);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
