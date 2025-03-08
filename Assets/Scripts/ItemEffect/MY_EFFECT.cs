using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class MY_EFFECT : UsableItem.UsageEffect
{
    public int poison;
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(poison);
        return true;
    }
}
