using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddHealthEffects : UsableItem.UsageEffect
{
    public int healthIncrease;
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(healthIncrease);
        return true;
    }
}
