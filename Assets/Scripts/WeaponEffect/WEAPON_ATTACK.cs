using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class WEAPON_ATTACK : Weapon.WeaponAttackEffect
{
    private int damageBonus = 5;
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        attackData.AddDamage(StatSystem.DamageType.Physical, damageBonus);
        Debug.Log("damage bonus");
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        
    }
}
