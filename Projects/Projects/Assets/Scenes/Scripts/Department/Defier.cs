using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//对抗部门的属性
public class Defier : MonoBehaviour
{
    public float MaxHealthValue = 100;//最大生命值
    public float AttackValue = 40;//攻击
    public float DefenceValue = 20;//防御
    public float MagicDefenceValue = 10;//法抗
    public float CurHealthValue;//目前生命值
    public float AvoidValue = 10;//闪避
    public float Sanity = 100;//sanity值
    float BloodScale;//血量的比例
    public Vector2 lookDirection = new Vector2(0, 1);//默认朝右
    // Start is called before the first frame update
    void Start()
    {
        CurHealthValue = 100;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                GameObject monster = hit.collider.gameObject;
                SmallSkill(monster);
            }
        }
    }
    /**
    被动
    **/
    public void PassiveSkill()
    {
        BloodScale = CurHealthValue / MaxHealthValue;
        if (BloodScale < 0.5)
        {
            //生命值低于50%
            AttackValue *= (float)1.2;
        }
    }
    /**
    小技能
    **/
    public void SmallSkill(GameObject monster)
    {

    }
    /**
    大技能
    **/
    public void BigSkill(/*传入敌人参数*/)
    {

    }
}
