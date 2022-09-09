using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour
{
    public BaseCharacter character;
    public Text nameText;
    public Text hpText;
    public Text ageText;
    public Text strengthText;
    public Text durText;
    public Text agiText;
    public Text intText;
    public Text magText;
    public Text luckText;
    public Text potText;
    void Start(){
        character.SetValues();
        nameText.text = character.name;
        hpText.text = character.health.ToString();
        ageText.text = character.age.ToString();
        strengthText.text = character.strength.ToString();
        durText.text = character.durability.ToString();
        agiText.text = character.agility.ToString();
        intText.text = character.intelligence.ToString();
        magText.text = character.magic.ToString();
        luckText.text = character.luck.ToString();
        potText.text = character.potential.ToString();
       
    }
}
