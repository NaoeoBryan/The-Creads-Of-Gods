using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleInterface : MonoBehaviour
{
    public GameObject inventoryPanel;
    bool invActive = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            invActive = !invActive;
            inventoryPanel.SetActive(invActive);
        }
    }
}
