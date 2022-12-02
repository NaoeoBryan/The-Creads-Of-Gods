using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Não tem veneno ou ataque paralisante(magias e etc.)

    // Testes de resistência são o que vão definir se um usuário fica ou não envenenado por um ataque feito com veneno, se ele fica ou não paralisado como efeito consequente de uma magia e diversos outros fatores.
    // Resultado do RNG(d20) + Modificador de Habilidade + Bônus de proficiência



    /* CD(classe de dificuldade)
     { //SEI NEM QUE PORRA É ESSA//
         Toda habilidade tem uma CD diferente baseada em qual atributo é o principal para realizar ela
     8 + Modificador de Habilidade +Bônus de proficiência
     NÃO existe erro crítico e acerto crítico em testes de resistência
     */

    /*
     *  GRANDE parte das magias vão exigir um teste de resistência do inimigo, pois para ser atingido por uma magia que cria uma explosão, 
     *  não é necessário ser atingido diretamente. Sendo assim, o alvo do ataque faz um teste de resistência que define se ele conseguiu se esquivar parcialmente do ataque ou não.
     *  Isso é, se o alvo não passar no teste contra a CD da magia, ele tomará o dano completo dela, se ele passar ele sofrerá apenas metade.
     */

}
