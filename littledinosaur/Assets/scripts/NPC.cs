using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// NPC�欰
/// �����ؼжi�J�I����
/// ��ܹ�ܨt��
/// </summary>
public class NPC : MonoBehaviour
{
    [Header("��ܸ��")]
    public DataDia Datadialogue;
    [Header("��ܨt��")]
    public DislogueSystem DialogueSystem;

    // Ĳ�o�}�l�ƥ�
    // 1.��Ӫ��󳣭n�� collider 2D
    // 2.��ӭn���@�� rigbody 2D
    // 3.��ӭn���@�Ӥ� is trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("���F��i�J�ϰ�F");
    }
}



