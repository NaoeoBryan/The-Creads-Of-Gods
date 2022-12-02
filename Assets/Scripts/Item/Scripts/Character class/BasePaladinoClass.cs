using UnityEngine;
using System.Collections;

public class BasePaladinoClass : BaseCharacterClass
{

    public void PaladinoClass()
    {
        CharacterClassName = "Paladino";
        CharacterClassDescritpion = "Proeficiente em testes de força e refinamento";
        
        Forca = 10;
        constituicao = 10; //10 por nivel (tem que colocar o sistema de nivel no personagem, essa pika não é minha.)
        destreza = 10;
        refinamento = 10;
        resistencia = 10;
        intensidade = 10;
    }



}