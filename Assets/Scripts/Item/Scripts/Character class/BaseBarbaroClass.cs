using UnityEngine;
using System.Collections;

public class BaseBarbaroClass : BaseCharacterClass
{

    public void BarbaroClass()
    {
        CharacterClassName = "Bárbaro";
        CharacterClassDescritpion = "Proficiente em testes de Força e Constituição.";
        Forca = 10;
        constituicao = 10; //12 por nivel (tem que colocar o sistema de nivel no personagem, essa pika não é minha.)
        destreza = 10;
        refinamento = 10;
        resistencia = 10;
        intensidade = 10;

    }
}
