using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botas : MonoBehaviour
{
    public string nome;
    public int id;
    public int defesa;
    public int vida;

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
    public int Defesa
    {
        get { return defesa; }
        set { defesa = value; }
    }
    public int Vida
    {
        get { return vida; }
        set { vida = value; }

    }
}
