using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour
{
    private void Awake()
    {
        EventCenter.Instance.AddEventListener("MonsterDead", OtherWaitMonsterDeadDo);
    }

    public void OtherWaitMonsterDeadDo()
    {
        Debug.Log("其他相关处理");
    }

    private void OnDestroy()
    {
        EventCenter.Instance.RemoveEventListener("MonsterDead", OtherWaitMonsterDeadDo);
    }
}
