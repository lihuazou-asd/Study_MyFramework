using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMgr
{
    public static TestMgr instance;
    // 通过属性获取
    public static TestMgr Instance{
        get{
            if(instance == null){
                instance = new TestMgr();
            }
            return instance;
        }
    }
    // 通过方法获取
    public static TestMgr GetInstance(){
        if(instance == null){
            instance = new TestMgr();
        }
        return instance;
    }
}
