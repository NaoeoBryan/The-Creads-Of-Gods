using UnityEngine;
using System.Collections;

public class BaseLadinoClass : BaseCharacterClass
{

    public void LadinoClass()
    {
        CharacterClassName = "Ladino";
        CharacterClassDescritpion = "Proeficiente em testes de refinamento e destreza.";

        Forca = 10;
        constituicao = 10; //8 por nivel (tem que colocar o sistema de nivel no personagem, essa pika não é minha.)
        destreza = 10;
        refinamento = 10;
        resistencia = 10;
        intensidade = 10;
    }
}