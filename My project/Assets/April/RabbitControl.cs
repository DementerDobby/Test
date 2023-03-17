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

        //rigidbody ��ü ���� �� �䳢 ������Ʈ�� Rigidbody������Ʈ
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        //�� ������ ȣ��Ǵ� update() ������ ���ÿ� Movement()�޼ҵ� ȣ��
    }

    public void Movement()
    {
        playerPosition = this.transform.position;
        //�� ��ü�� �����̴� ��Ұ� ������ Rigidbody�� wasd�Ӹ� �ƴ϶�, use gravity�� ����ؼ� �߷��� ����Ǳ⋚���� �߷¿� ���� ��ȭ�� ������ �ؾ� ��. �׷��Ƿ� ���� ��ġ ��� ����

        if (Input.GetKey(KeyCode.W))
        {
            playerPosition += Vector3.forward * moveSpeed * Time.deltaTime;
            //��ü�� ��ġ�� ���ŵǸ� �״��� Vector3.forward��� ������ǥ���� '��' ����, �ӵ�, �ð��� 60����1 �� ������ �� 
            //playerPosition�� �����ش�.
            rid.MovePosition(playerPosition);
            //���� movePosition���� ���� ���ŵ� ��ġ�� �̵��� ����.
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
