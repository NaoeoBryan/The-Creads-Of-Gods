using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pocaovida : MonoBehaviour
{
    public string nome;
    public int id;
    public int vidaregen;
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
    public int Vidaregen
    {
        get { return vidaregen; }
        set { id = value; }
    }
    public int Quantidade
    {
        get { return quantidade; }
        set { quantidade = value; }
    }
}
