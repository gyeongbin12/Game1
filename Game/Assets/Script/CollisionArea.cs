using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionArea : MonoBehaviour
{
    [SerializeField] int count;

    private void OnTriggerEnter(Collider other)
    {
            GameEvent.instance.DoorTriggerEnter(count);
 
    }

    private void OnTriggerExit(Collider other)
    {
        // Invoke 특정 시간 후에 함수를 실행하는 함수
        // 3초 뒤에 DoorTriggerExit를 호출합니다
        GameEvent.instance.DoorTriggerExit(count);
    }
}
