using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//对抗部门的属性
public class Defier : MonoBehaviour
{
    Character_Stats characterStats;  //用来读取该对象数据，如characterStats.MaxHealthValue
    Character_Stats othercharacterStats;
    
    public Vector2 lookDirection = new Vector2(0, 1);//默认朝右
    // Start is called before the first frame update
    private void Awake()
    {
        characterStats = GetComponent<Character_Stats>();            
    }
    void Start()
    {
        
        Application.targetFrameRate = 60;
        characterStats.MaxHealthValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }
    GameObject getGameObject()//获取鼠标点击的对象
    {
        GameObject gameobject=null;   
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                gameobject = hit.collider.gameObject;

            }
            othercharacterStats = GetComponent<Character_Stats>();
        }
        return gameobject;
    }
    /**
     平a
    **/
    void Attack()
    {
       GameObject MateOrEnemy = getGameObject();
       Character_Stats target = MateOrEnemy.GetComponent<Character_Stats>();
       target.takeDamage(characterStats,target);
     //   Debug.Log(target.CurHealthValue);
    }
    /**
    被动
    **/
    public void PassiveSkill()
    { float HalfHealthValue = characterStats.CurHealthValue / 2;
        if (characterStats.CurHealthValue< HalfHealthValue) 
        {
            characterStats.AttackValue *= 1.2f;
        }
  
    }
    /**
    小技能
    **/
    public void SmallSkill()
    {

    }
    /**
    大技能
    **/
    public void BigSkill()
    {

    }
}
