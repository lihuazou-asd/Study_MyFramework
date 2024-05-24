using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �����(�����)ģ�� ������
/// </summary>
public class PoolMgr : BaseManagerConSecure<PoolMgr>
{
    //�������������г��������
    private Dictionary<string, Stack<GameObject>> poolDic = new Dictionary<string, Stack<GameObject>>();

    private PoolMgr() { }

    /// <summary>
    /// �ö����ķ���
    /// </summary>
    /// <param name="name">��������������</param>
    /// <returns>�ӻ������ȡ���Ķ���</returns>
    public GameObject GetObj(string name)
    {
        GameObject obj;
        //�г��� ���� ������ �ж��� ��ȥֱ����
        if(poolDic.ContainsKey(name) && poolDic[name].Count > 0)
        {
            //����ջ�еĶ��� ֱ�ӷ��ظ��ⲿʹ��
            obj = poolDic[name].Pop();
            //������� �ٷ���
            obj.SetActive(true);
        }
        //���򣬾�Ӧ��ȥ����
        else
        {
            //û�е�ʱ�� ͨ����Դ���� ȥʵ������һ��GameObject
            obj = GameObject.Instantiate(Resources.Load<GameObject>(name));
            //����ʵ���������Ķ��� Ĭ�ϻ������ֺ����һ��(Clone)
            //�������������� �����������
            obj.name = name;
        }

        return obj;
    }


    /// <summary>
    /// ��������з������
    /// </summary>
    /// <param name="name">���루���󣩵�����</param>
    /// <param name="obj">ϣ������Ķ���</param>
    public void PushObj(GameObject obj)
    {
        //��֮��Ŀ�ľ���Ҫ�Ѷ�����������
        //������ֱ���Ƴ����� ���ǽ�����ʧ�� һ������� �õ�ʱ���ټ�����
        //�������ַ�ʽ�������԰Ѷ���ŵ���Ļ�⿴�����ĵط�
        obj.SetActive(false);

        //û�г��� ��������
        if(!poolDic.ContainsKey(obj.name))
            poolDic.Add(obj.name, new Stack<GameObject>());

        //�����뵱�зŶ���
        poolDic[obj.name].Push(obj);

        ////������ڶ�Ӧ�ĳ������� ֱ�ӷ�
        //if(poolDic.ContainsKey(name))
        //{
        //    //��ջ�����룩�з������
        //    poolDic[name].Push(obj);
        //}
        ////���� ��Ҫ�ȴ������� �ٷ�
        //else
        //{
        //    //�ȴ�������
        //    poolDic.Add(name, new Stack<GameObject>());
        //    //�������������
        //    poolDic[name].Push(obj);
        //}
    }

    /// <summary>
    /// ��������������ӵ��е����� 
    /// ʹ�ó��� ��Ҫ�� �г���ʱ
    /// </summary>
    public void ClearPool()
    {
        poolDic.Clear();
    }
}
