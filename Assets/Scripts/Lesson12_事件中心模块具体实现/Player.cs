using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Awake()
    {
        EventCenter.Instance.AddEventListener("MonsterDead", PlayerWaitMonsterDeadDo);
    }

    public void PlayerWaitMonsterDeadDo()
    {
        Debug.Log("玩家得奖励");
    }

    private void OnDestroy()
    {
        EventCenter.Instance.RemoveEventListener("MonsterDead", PlayerWaitMonsterDeadDo);
    }
}
