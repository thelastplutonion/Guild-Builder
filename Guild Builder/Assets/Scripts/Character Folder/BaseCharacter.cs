using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class BaseCharacter : ScriptableObject{

    public new string name;
    public BaseJobClass job;
    public int lvl, health, age, strength, durability, agility, intelligence, magic, luck, potential;
    public int[] stats = new int[7];
    private int tempMax;

    public void SetValues(){
        for (int i = 0; i < 7; i++) {
            stats[i] = Random.Range(5, 20);
            if (stats[i] > tempMax)
                tempMax = stats[i];
        }
        //strength = Random.Range(0,20);
        strength = stats[0];
        durability = stats[1];
        agility = stats[2];
        intelligence = stats[3];
        magic = stats[4];
        luck = stats[5];
        potential = stats[6];

        job.AddJob(this);
    }

    public void Print(){
        Debug.Log(name + ": " + age + " Max Number: " + tempMax);
        for (int i = 0; i < 7; i++) {
            Debug.Log(stats[i] + ": ");
        }
    }
}
