using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitControl : MonoBehaviour
{
    Rigidbody rid;

    Vector3 playerPosition;

    [SerializeField]
    private float moveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rid = GetComponent<Rigidbody>(); 

        //rigidbody 객체 생성 후 토끼 오브젝트의 Rigidbody컴포넌트
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        //매 프레임 호출되는 update() 문에서 동시에 Movement()메소드 호출
    }

    public void Movement()
    {
        playerPosition = this.transform.position;
        //이 물체를 움직이는 요소가 오로지 Rigidbody의 wasd뿐만 아니라, use gravity를 사용해서 중력이 적용되기떄문에 중력에 의한 변화도 갱신을 해야 함. 그러므로 실제 위치 계속 적용

        if (Input.GetKey(KeyCode.W))
        {
            playerPosition += Vector3.forward * moveSpeed * Time.deltaTime;
            //물체의 위치가 갱신되면 그다음 Vector3.forward라는 세계좌표기준 '앞' 값과, 속도, 시간의 60분의1 을 곱해준 후 
            //playerPosition에 더해준다.
            rid.MovePosition(playerPosition);
            //이제 movePosition덕에 새로 갱신된 위치로 이동될 것임.
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerPosition += Vector3.left * moveSpeed * Time.deltaTime;

            rid.MovePosition(playerPosition);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerPosition -= Vector3.forward * moveSpeed * Time.deltaTime;
            rid.MovePosition(playerPosition);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerPosition -= Vector3.left * moveSpeed * Time.deltaTime;
            rid.MovePosition(playerPosition);
        }
    }
}
