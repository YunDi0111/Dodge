using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f; //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidibody; //�̵��� ����� ������ٵ� ������Ʈ
    void Start()
    {   //���ӿ�����Ʈ���� Rigidbody������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidibody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidibody.velocity = transform.forward * speed;

        //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 10f);
    }
    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼ҵ�
    private void OnTriggerEnter(Collider other)
    {   //�浹�� ���� ���� ������Ʈ�� player�±׸� ���� ���
        if(other.tag == "Player")
        {   //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();

            //�������κ��� PlayerController ������Ʈ�� �������µ� �����ߴٸ�
            if(playerController != null) // <-  ������ ������ ���ٰ� ������ 
            {   //���� PlayerController ������Ʈ�� Die() �޼��� ����
                playerController.Die();
            }
        }
        
    }
    void Update()
    {
        
    }
}
