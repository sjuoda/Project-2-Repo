using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class Beer : UsableItem.UsageEffect
{
    public int healthDecrease;
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(healthDecrease);
        return true;
    }
}
