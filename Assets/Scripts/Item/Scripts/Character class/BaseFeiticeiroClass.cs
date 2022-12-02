using UnityEngine;
using System.Collections;

public class BaseFeiticeiroClass : BaseCharacterClass
{

    public void FeiticeiroClass()
    {
        CharacterClassName = "Feiticeiro";
        CharacterClassDescritpion = "Proeficiente em testes de refinamento e intensidade.";
        
        Forca = 10;
        constituicao = 10; //6 por nivel (tem que colocar o sistema de nivel no personagem, essa pika não é minha.)
        destreza = 10;
        refinamento = 10;
        resistencia = 10;
        intensidade = 10;
    }
}