using UnityEngine;

public class workerAnt : ant
{
    void Start()
    {
        
    }

    void Update()
    {
        walk();
    }

    void walk()
    {
        transform.position += new Vector3(1/10.0f, 0f, 0f);
    }
}
