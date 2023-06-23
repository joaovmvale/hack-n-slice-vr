using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vinisius : MonoBehaviour
{

    public Slider slider;
    public GameObject explosion;
    public GameObject counterTerrorist;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform) {
            child.gameObject.GetComponent<MeshCollider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider col) {
        if (slider.value <= 0) {
            StartCoroutine(ExampleCoroutine());
            foreach (Transform child in transform) {
                child.gameObject.GetComponent<MeshCollider>().enabled = true;
            }
        }
        if (col.tag == "Blade") {
            slider.value -= 0.05f;
        }
    }
    IEnumerator ExampleCoroutine()
    {
        explosion.SetActive(true);
        yield return new WaitForSeconds(1);
        counterTerrorist.SetActive(true);
        yield return new WaitForSeconds(2);
        transform.gameObject.SetActive(false);
        canvas.SetActive(false);
    }
}
