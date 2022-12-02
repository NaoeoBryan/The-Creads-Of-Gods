using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public GameObject space;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(space , 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
