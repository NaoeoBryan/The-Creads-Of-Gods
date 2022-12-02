using UnityEngine;
using System.Collections;

public class BaseCharacterClass
{
    private string characterClassName;
    private string characterClassDescritpion;
    //stats MIN 1, MAX 30(ta dando erro ali em baixo).
    /*
     * FÍSICOS:

Força: Usado para atacar com armas que não sejam leves. 
----------------------------------------------------------------------------------------------------------------
Destreza: Serve para aumentar a defesa do jogador e é usada para atacar com armas a distância ou armas leves
------------------------------------------------------------------------------------------------------------------
Constituição: Constituição altera diretamente na quantidade máxima de vida que o jogador e as criaturas tem, 
seu modificador é multiplicado pelo nível do usuário e esse valor se torna o bônus de HP total que a constituição gera
     */
    public int destreza = 0;
    public int constituicao; 
    public int forca;

    public int inidestreza = 10; //temporario

/*MÁGICOS:

Refinamento: Refinamento altera diretamente na quantidade máxima de energia que o usuário é capaz de ter.
Funcionando de forma similar a constituição. seu modificador é multiplicado pelo nível do usuário e esse valor se torna o bônus de energia total que o refinamento gera.
Além disso, é usado para atacar com magias que requerem que o jogador acerte-a e não que o inimigo desvie (Explicações mais detalhadas em outro tópico)
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Resistência: Resistência nada mais é que a "Defesa Mágica" do usuário, quanto maior esse valor, mais resistente o usuário vai ser contra efeitos mágicos negativos que intervenham em sua mana ou magia.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Intensidade: Intensidade afeta diretamente os valores variáveis de uma magia ou habilidade, na grande maioria das vezes esse valor vai se referir ao dano da magia ou habilidade,
mas em casos de magia de cura a intensidade também interfere nesse valor.
 */
    public int refinamento;
    public int resistencia;
    public int intensidade;


    /*ta dando erro, deixei comentado
     * if(destreza >= 1){
        destreza = destreza;
    }  */

    //nome da classe 
    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }
    //descrição da classe
    public string CharacterClassDescritpion
    {
        get { return characterClassDescritpion; }
        set { characterClassDescritpion = value; }
    }
    //get e set destreza
    public int Destreza
    {
        get { return destreza; }
        set { destreza = value; }
    }
    //get e set constituição
    public int Constituicao
    {
        get { return constituicao; }
        set { constituicao = value; }
    }
    //get e set força
    public int Forca
    {
        get { return forca; }
        set { forca = value; }
    }
    //get e set refinamento
    public int Refinamento
    {
        get { return refinamento; }
        set { refinamento = value; }
    }
    //get e set resistencia
    public int Resistencia
    {
        get { return resistencia; }
        set { resistencia = value; }
    }
    //get e set intensidade
    public int Intensidade
    {
        get { return intensidade; }
        set { intensidade = value; }
    }
}