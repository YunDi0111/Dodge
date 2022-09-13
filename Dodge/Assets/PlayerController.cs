using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRididbody;   //�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;    //�̵��ӷ�
    
    void Start()
    {   //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        playerRididbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {   //�� ����Ű �Է��� ������ ��� z���� ���ֱ�
            playerRididbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {   //�Ʒ� ����Ű �Է��� ������ ��� -z���� ���ֱ�
            playerRididbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {   //���� ����Ű �Է��� ������ ��� x���� ���ֱ�
            playerRididbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {   //�� ����Ű �Է��� ������ ��� -x���� ���ֱ�
            playerRididbody.AddForce(-speed, 0f, 0f);
        }
    }
    public void Die()
    {   //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}
