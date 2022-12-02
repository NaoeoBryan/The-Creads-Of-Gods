using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pocaomana : MonoBehaviour
{
    public string nome;
    public int id;
    public int manaregen;
    public int quantidade;

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
    public int Manaregen
    {
        get { return manaregen; }
        set { id = value; }
    }
    public int Quantidade
    {
        get { return quantidade; }
        set { quantidade = value; }
    }
}
