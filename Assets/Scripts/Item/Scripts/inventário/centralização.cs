using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centralização : MonoBehaviour
{
    void Update()
    {
        transform.position += (transform.parent.position - transform.position) * 50 * Time.deltaTime;
    }
}
