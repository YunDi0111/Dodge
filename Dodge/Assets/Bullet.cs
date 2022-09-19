using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; //탄알 이동 속력
    private Rigidbody bulletRigidibody; //이동에 사용할 리지드바디 컴포넌트
    void Start()
    {   //게임오브젝트에서 Rigidbody컴포넌트를 찾아 bulletRigidbody에 할당
        bulletRigidibody = GetComponent<Rigidbody>();
        //리지드바디의 속도 = 앞쪽 방향 * 이동 속력
        bulletRigidibody.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
