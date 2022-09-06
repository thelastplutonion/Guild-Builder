using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass {

    //Character Information
    private string characterName, characterDescription;
    private int health, mana, stamina, money, age;

    //stat blocks
    private int strength, durability, intelligence, agility, magic, luck, potential;

    //classes
    public BaseJobClass job;

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
    public int Age
    {
        get { return age; }
        set { age = value; }
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
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Durability
    {
        get { return durability; }
        set { durability = value; }
    }
    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }
    public int Agility
    {
        get { return agility; }
        set { agility = value; }
    }
    public int Magic
    {
        get { return magic; }
        set { magic = value; }
    }
    public int Luck
    {
        get { return luck; }
        set { luck = value; }
    }
    public int Potential
    {
        get { return potential; }
        set { potential = value; }
    }
    public int Money
    {
        get { return money; }
        set { money = value; }
    }

}
