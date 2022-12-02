using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventario : MonoBehaviour   
{
    public Item[] item;

    public GameObject mouseItem;

    public void dragItem( GameObject Button )
    {
        mouseItem = Button;
        mouseItem.transform.position = Input.mousePosition;
    }   
    public void dropItem( GameObject button )
    {
        if(mouseItem != null)
        {
            Transform aux = mouseItem.transform.parent;
            mouseItem.transform.SetParent(button.transform.parent);
            button.transform.SetParent(aux);
            
        }
    }
}
