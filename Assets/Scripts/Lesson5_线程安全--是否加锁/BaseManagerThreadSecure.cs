using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class BaseManagerThreadSecure<T> where T:class
{
    //不可以直接通过Instance!=null进行判断，因为如果通过Instance来判断，如果instance为null，会执行反射并进行构造行成循环
    protected bool InstancIsNull => instance == null;
    //readonly是为了防止物体被修改
    protected static readonly object lockObj = new object();
    private static T instance;
    public static T Instance
    {
        get
        {
            if(instance == null){
                lock(lockObj){
                    if(instance == null){
                        //3.利用反射来获取类型Type
                        Type type = typeof(T);
                        //通过Type来获取私有构造函数
                        ConstructorInfo constructorInfo = type.GetConstructor(BindingFlags.Instance|BindingFlags.NonPublic,null,Type.EmptyTypes,null);
                        //执行构造函数并赋值
                        instance = constructorInfo.Invoke(null) as T;

                        //还可以通过Activator来快捷实例化
                        // instance = Activator.CreateInstance(type,true) as T;
                    }
                }
            }
            return instance;
        }
    }

}
