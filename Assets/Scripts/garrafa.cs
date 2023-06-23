using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garrafa : MonoBehaviour
{

    public GameObject explosion;
    public GameObject counterTerrorist;
    
    private void OnTriggerEnter(Collider col) {
        if (col.tag == "Blade") {
            StartCoroutine(ExampleCoroutine());
        }
    }
 
    IEnumerator ExampleCoroutine()
    {
        explosion.SetActive(true);
        yield return new WaitForSeconds(1);
        counterTerrorist.SetActive(true);
        yield return new WaitForSeconds(2);
        transform.parent.gameObject.SetActive(false);
    }
}
