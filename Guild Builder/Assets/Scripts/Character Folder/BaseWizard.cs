using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWizard : BaseCharacterClass{

    public void WizardClass() {
        CharacacterName = "Wizard";
        CharacacterDescription = "Magic caster for the ages!";
        Health = 100;
        Mana = 100;
        Stamina = 15;
    }
}
