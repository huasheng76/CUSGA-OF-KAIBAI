using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Data",menuName ="Character Stats/Data")]
public class CharacterData_SO : ScriptableObject
{
    [Header("Stats Info")]
    public float MaxHealthValue;//�������ֵ
     public float CurHealthValue;//Ŀǰ����ֵ

    public float AttackValue;//����

    public float DefenceValue;//����
    public float MagicDefenceValue;//����
   
    public float AvoidValue;//����

    public float Sanity;//sanityֵ

}
