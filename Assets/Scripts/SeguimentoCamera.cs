using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimentoCamera : MonoBehaviour
{
    public Transform player;
  

private void Update(){
 
    transform.position = new Vector3(player.transform.position.x,player.transform.position.y,transform.position.z);

}




}
