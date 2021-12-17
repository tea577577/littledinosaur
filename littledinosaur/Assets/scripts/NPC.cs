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
    [Header("Ĳ�o��ܪ���H")]
    public string target = "���s";

    // Ĳ�o�}�l�ƥ�
    // 1.��Ӫ��󳣭n�� collider 2D
    // 2.��ӭn���@�� rigbody 2D
    // 3.��ӭn���@�Ӥ� is trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // print("�I��");
        if (collision.name == target)
        {
            DialogueSystem.StartDialogue(Datadialogue.dialogues);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            DialogueSystem.StopDialogue();
        }
    }
}



