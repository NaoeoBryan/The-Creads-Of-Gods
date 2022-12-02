using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espada : MonoBehaviour
{
    public string nome;
    public int id;
    public int dano;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public int Dano
    {
        get { return dano; }
        set { dano = value; }
    }

}
