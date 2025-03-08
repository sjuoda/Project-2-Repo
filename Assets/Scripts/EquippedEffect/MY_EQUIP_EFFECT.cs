using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class MY_EQUIP_EFFECT : EquipmentItem.EquippedEffect
{
     int healthDouble;
     int healthHalf;
     public override void Equipped(CharacterData user)
     {
          healthDouble = user.Stats.CurrentHealth * 2;
          user.Stats.ChangeHealth(healthDouble);
     }
     
     public override void Removed(CharacterData user)
     {
          healthHalf = user.Stats.CurrentHealth / 2;
          user.Stats.ChangeHealth(healthHalf);
     }
}
