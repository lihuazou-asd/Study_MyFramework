using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMgrConSecure1:BaseManagerConSecure<TestMgrConSecure1>
{
    //2.私有化构造函数防止new对象
    private TestMgrConSecure1(){
        //通过判断是否存在Instance防止其它人通过反射继续new实例
        if(!InstancIsNull){//不可以直接通过Instance!=null进行判断，因为如果通过Instance来判断，如果instance为null，会执行反射并进行构造行成循环
            Debug.LogError("已存在单例，无需再通过反射实例化");
        }
    }

    public void Speak(){
        Debug.Log("TestMgrConSecure1");
    }
}
