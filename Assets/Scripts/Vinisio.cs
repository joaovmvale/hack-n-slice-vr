using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vinisio : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject vinisio;
    public GameObject conglomerado;

    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(6 /* 1000 * 60*/);
        vinisio.SetActive(true);
        conglomerado.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
