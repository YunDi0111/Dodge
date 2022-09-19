using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidibody; //�̵��� ����� ������ٵ� ������Ʈ
    void Start()
    {   //���ӿ�����Ʈ���� Rigidbody������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidibody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidibody.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
