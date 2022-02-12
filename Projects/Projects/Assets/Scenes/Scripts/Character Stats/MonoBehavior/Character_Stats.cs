using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Stats : MonoBehaviour
{
    public CharacterData_SO characterData;
    public float MaxHealthValue
    {
        get
        {
            if (characterData != null) { return characterData.MaxHealthValue; }
            else return 0;
        }
        set
        {
            characterData.MaxHealthValue = value;
        }
    }
    public float AttackValue
    {
        get
        {
            if (characterData != null) { return characterData.AttackValue; }
            else return 0;
        }
        set
        {
            characterData.AttackValue = value;
        }
    }
    public float CurHealthValue
    {
        get
        {
            if (characterData != null) { return characterData.CurHealthValue; }
            else return 0;
        }
        set
        {
            characterData.CurHealthValue = value;
        }
    }
    public float DefenceValue
    {
        get
        {
            if (characterData != null) { return characterData.DefenceValue; }
            else return 0;
        }
        set
        {
            characterData.DefenceValue = value;
        }
    }
    public float MagicDefenceValue
    {
        get
        {
            if (characterData != null) { return characterData.MagicDefenceValue; }
            else return 0;
        }
        set
        {
            characterData.MagicDefenceValue = value;
        }
    }
    public float AvoidValue
    {
        get
        {
            if (characterData != null) { return characterData.AvoidValue; }
            else return 0;
        }
        set
        {
            characterData.AvoidValue = value;
        }
    }
    public float Sanity
    {
        get
        {
            if (characterData != null) { return characterData.Sanity; }
            else return 0;
        }
        set
        {
            characterData.Sanity = value;
        }
    }

    public void takeDamage(Character_Stats attacker,Character_Stats defender)
    {
        float damage = Mathf.Max((attacker.AttackValue - defender.DefenceValue), 0.05f * attacker.AttackValue);
        CurHealthValue = Mathf.Max(CurHealthValue - damage, 0);
    }

}
