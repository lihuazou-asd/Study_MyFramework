using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ��Ҫ���ݻع�
        //��������Monoģ��ر�֪ʶ��
        //1.ί���¼� ���֪ʶ��C#�Ĳ���C#�����У�
        //2.�������ں��� ���֪ʶ��Unity�Ĳ���֮Unity�����У�
        //3.Эͬ���� ���֪ʶ��Unity�Ĳ���֮Unity������

        //����Monoģ�����Ҫ����
        //�ò��̳�MonoBehaviour�Ľű�Ҳ��
        //1.����֡���»�ʱ���´����߼�
        //2.����Эͬ�������߼�
        //3.����ͳһִ�й���֡���»�ʱ��������߼�(�������Ƿ�̳�MonoBehaviour)

        //����Monoģ��Ļ���ԭ��
        //1.ͨ���¼���ί�� ���� ��ظ��º���
        //2.�ṩЭͬ��������رյķ���
        #endregion

        #region ֪ʶ��һ ʵ�ֹ���Monoģ��
        //1.����MonoMgr�̳� �Զ�����ʽ�ļ̳�MonoBehaviour�ĵ���ģʽ����
        //2.ʵ��Update��FixedUpdate��LateUpdate�������ں���
        //3.������Ӧ�¼���ί�����ڴ洢�ⲿ���������ṩ����Ƴ��������Ӷ��ﵽ�ò��̳�MonoBehaviour�Ľű�����ִ��֡���»�ʱ���µ�Ŀ��
        //4.����Эͬ�������رպ������Ӷ��ﵽ�ò��̳�MonoBehaviour�Ľű�����ִ��Эͬ�����Ŀ��
        #endregion

        #region ֪ʶ��� ����
        MonoMgr.Instance.AddUpdateListener(MyUpdate);
        #endregion
    }

    private void MyUpdate()
    {
        print("Lesson6");
    }
}
