using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRididbody;   //이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f;    //이동속력
    
    void Start()
    {   //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRididbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {   //위 방향키 입력이 감지된 경우 z방향 힘주기
            playerRididbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {   //아래 방향키 입력이 감지된 경우 -z방향 힘주기
            playerRididbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {   //오른 방향키 입력이 감지된 경우 x방향 힘주기
            playerRididbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {   //왼 방향키 입력이 감지된 경우 -x방향 힘주기
            playerRididbody.AddForce(-speed, 0f, 0f);
        }
    }
    public void Die()
    {   //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
    }
}
