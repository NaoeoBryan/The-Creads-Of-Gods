using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour
{

    private BaseCharacterClass class1 = new BaseFeiticeiroClass();
    private BaseCharacterClass class2 = new BaseBarbaroClass();
    private BaseCharacterClass class3 = new BasePaladinoClass();
    private BaseCharacterClass class4 = new BaseLadinoClass();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {

        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescritpion);
        GUILayout.Label(class1.forca.ToString());
        GUILayout.Label(class1.destreza.ToString());
        GUILayout.Label(class1.constituicao.ToString());
        GUILayout.Label(class1.refinamento.ToString());
        GUILayout.Label(class1.resistencia.ToString());
        GUILayout.Label(class1.intensidade.ToString());

        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescritpion);
        GUILayout.Label(class2.forca.ToString());
        GUILayout.Label(class2.destreza.ToString());
        GUILayout.Label(class2.constituicao.ToString());
        GUILayout.Label(class2.refinamento.ToString());
        GUILayout.Label(class2.resistencia.ToString());
        GUILayout.Label(class2.intensidade.ToString());

        GUILayout.Label(class3.CharacterClassName);
        GUILayout.Label(class3.CharacterClassDescritpion);
        GUILayout.Label(class3.forca.ToString());
        GUILayout.Label(class3.destreza.ToString());
        GUILayout.Label(class3.constituicao.ToString());
        GUILayout.Label(class3.refinamento.ToString());
        GUILayout.Label(class3.resistencia.ToString());
        GUILayout.Label(class3.intensidade.ToString());

        GUILayout.Label(class4.CharacterClassName);
        GUILayout.Label(class4.CharacterClassDescritpion);
        GUILayout.Label(class4.forca.ToString());
        GUILayout.Label(class4.destreza.ToString());
        GUILayout.Label(class4.constituicao.ToString());
        GUILayout.Label(class4.refinamento.ToString());
        GUILayout.Label(class4.resistencia.ToString());
        GUILayout.Label(class4.intensidade.ToString());

    }
}