using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dead();
    }

    void Dead()
    {
        Debug.Log("怪物死亡了");
        //其他对象在怪物死亡时想做的事情
        //比如
        //1.任务更新
        GameObject.Find("Task").GetComponent<Task>().TaskWaitMonsterDeadDo();
        //2.玩家得奖励
        GameObject.Find("Player").GetComponent<Player>().PlayerWaitMonsterDeadDo();
        //3.其他相关系统
        GameObject.Find("Other").GetComponent<Other>().OtherWaitMonsterDeadDo();
        //n个其他相关处理
    }
}
