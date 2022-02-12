using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Data",menuName ="Character Stats/Data")]
public class CharacterData_SO : ScriptableObject
{
    [Header("Stats Info")]
    public float MaxHealthValue;//最大生命值
     public float CurHealthValue;//目前生命值

    public float AttackValue;//攻击

    public float DefenceValue;//防御
    public float MagicDefenceValue;//法抗
   
    public float AvoidValue;//闪避

    public float Sanity;//sanity值

}
