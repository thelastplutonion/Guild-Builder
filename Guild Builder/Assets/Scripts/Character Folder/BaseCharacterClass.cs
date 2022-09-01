using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass {

    //Character Information
    private string characterName, characterDescription;
    private int health, mana, stamina;

    public string CharacacterName
    {
        get { return characterName; }
        set { characterName = value; }
    }
    public string CharacacterDescription
    {
        get { return characterDescription; }
        set { characterDescription = value; }
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    public int Mana
    {
        get { return mana; }
        set { mana = value; }
    }
    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
}
