using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorio : MonoBehaviour
{
    public int d20 = 0;

    public void numeroAleatorio()
    {
        d20 = Random.Range(1, 20); //valor 10 é neutro



    }


    /*
     * modificadores
     * 1 = -5
     * 2-3 = -4
     * 4-5 = -3
     * 5-7 = -2
     * 8-9 = -1
     * 10-11 = 0 Neutro
     * 12-13 = +1
     * 14-15 = +2
     * 16-17 = +3
     * 18-19 = +4
     * 20-21 = +5
     * 22-23 = +6
     * 24-25 = +7
     * 26-27 = +8
     * 28-29 = +9
     * 30 = +10 
     */     
    
}
