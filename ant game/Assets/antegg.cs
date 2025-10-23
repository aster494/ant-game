using UnityEngine;
using System.Collections;

public class antegg : MonoBehaviour
{
    public GameObject antprefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(balls());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    IEnumerator balls()
    {
        Instantiate(antprefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5);
        Instantiate(antprefab, transform.position, Quaternion.identity);
    }
}
