using UnityEngine;

// �إ߱M�פ������(menu = "���W��" ��Ƨ�/�l���)
[CreateAssetMenu(menuName = "1210/��ܸ��")]
/// <summary>
/// ��ܸ��
/// �O�s NPC �n�򪱮a�������e
/// </summary>
/// Sciptable Object �}���ƪ���G�g��������x�s�� Project ��������
public class DataDia : ScriptableObject
{
    // text Area (�̤p��ơA�̤j���) - �ȭ�string
    [Header("��ܤ��e"), TextArea(3, 5)]
    public string[] dislogues;
}
