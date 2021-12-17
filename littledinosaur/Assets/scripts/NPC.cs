using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// NPC行為
/// 偵測目標進入碰撞區
/// 顯示對話系統
/// </summary>
public class NPC : MonoBehaviour
{
    [Header("對話資料")]
    public DataDia Datadialogue;
    [Header("對話系統")]
    public DislogueSystem DialogueSystem;

    // 觸發開始事件
    // 1.兩個物件都要有 collider 2D
    // 2.兩個要有一個 rigbody 2D
    // 3.兩個要有一個勾 is trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("有東西進入區域了");
    }
}



