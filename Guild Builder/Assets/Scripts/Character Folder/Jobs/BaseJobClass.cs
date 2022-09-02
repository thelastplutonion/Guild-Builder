using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJobClass
{
    //Character Information
    private string jobName, jobDescription;
    private int health, mana, stamina;

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
