using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Job", menuName = "Job")]
public class BaseJobClass : ScriptableObject
{
    //Character Information
    public string jobName, jobDescription;
    private int health, mana, stamina, hitDie;

    public void AddJob(BaseCharacter character) { 
        if(jobName == "Artisan") {
            hitDie = 8;
            character.intelligence += 5;
            character.magic += 3;
            character.strength -= 4;
        }
        else if (jobName == "Brute")
        {
            hitDie = 12;
            character.strength += 5;
            character.durability += 3;
            character.intelligence -= 4;
        }

        // assign character health
        character.health = ((hitDie * character.lvl) + ((character.durability-10) * character.lvl));
    }
    public string JobName
    {
        get { return jobName; }
        set { jobName = value; }
    }
    public string JobDescription
    {
        get { return jobDescription; }
        set { jobDescription = value; }
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
