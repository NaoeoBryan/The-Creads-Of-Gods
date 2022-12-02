using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
	// Identidade dos campeãoes 
	public Text nameText;
	public Text levelText;
	public Slider hpSlider;

	public void SetHUD(Unit unit)
	{
		nameText.text = unit.unitName;
		levelText.text = "Lvl " + unit.unitLevel;
		hpSlider.maxValue = unit.maxHP;
		hpSlider.value = unit.currentHP;
	}
	// Mudando o status da vida de acordo que o combate acontece
	public void SetHP(int hp)
	{
		hpSlider.value = hp;
	}

}
