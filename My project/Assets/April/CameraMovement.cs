using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    public Transform player;

    private void Update()
    {
        transform.position = player.transform.position + new Vector3(0,3,-6);  // maincamera x,y,z 좌표 이동
                                                                               // 플레이어 따라가는 메인카메라 
    }
}
