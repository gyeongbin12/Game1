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
        // Invoke Ư�� �ð� �Ŀ� �Լ��� �����ϴ� �Լ�
        // 3�� �ڿ� DoorTriggerExit�� ȣ���մϴ�
        GameEvent.instance.DoorTriggerExit(count);
    }
}
