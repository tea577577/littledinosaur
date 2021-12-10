using UnityEngine;

// 建立專案內的選單(menu = "選單名稱" 資料夾/子資料)
[CreateAssetMenu(menuName = "1210/對話資料")]
/// <summary>
/// 對話資料
/// 保存 NPC 要跟玩家說的內容
/// </summary>
/// Sciptable Object 腳本化物件：經城市資料儲存至 Project 內的物件
public class DataDia : ScriptableObject
{
    // text Area (最小行數，最大行數) - 僅限string
    [Header("對話內容"), TextArea(3, 5)]
    public string[] dislogues;
}
