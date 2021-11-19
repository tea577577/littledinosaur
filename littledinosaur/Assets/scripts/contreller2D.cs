
using UnityEngine;

/// <summary>
/// 控制器：2D 橫向卷軸版本
/// </summary>

public class contreller2D : MonoBehaviour
{
    #region 欄位：公開
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 1500)]
    public float jump = 300;

    private Rigidbody2D rig;

    private void Start()
    {
        // 剛體欄位 = 取得元件<2D 剛體>()
        rig = GetComponent<Rigidbody2D>();
    }

    #endregion

    /// <summary>
    /// Update 約 60 FPS
    /// 固定更新事件：50 FPS
    /// 處理物理行為
    /// </summary>
    private void FixedUpdate()
    {
        Move();
    }

    #region 方法
    /// <summary>
    /// 1.玩家是否有按移動按鍵 左右方向或A、D
    /// 2.物件移動行為(API)
    /// </summary>

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        print("玩家左右鍵值：" + h);
    }
    #endregion

}
