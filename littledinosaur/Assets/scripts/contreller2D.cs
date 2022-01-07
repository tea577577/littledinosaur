
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
    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("跳躍按鍵與可跳躍圖層")]
    public KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;
    [Header("動畫參數：走路與跳躍")]
    public string parameterWalk = "走路開關";
    public string parameterJump = "跳躍開關";

    private Rigidbody2D rig;
    [SerializeField]
    /// <summary>
    /// 是否在地上
    /// </summary>
    private bool isGround;

    private void Start()
    {
        // 剛體欄位 = 取得元件<2D 剛體>()
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }


    #endregion

    #region 欄位：私人
    private Animator ani;
    /// <summary>
    /// Update 約 60 FPS
    /// 固定更新事件：50 FPS
    /// 處理物理行為
    /// </summary>
    private void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        Filp();
        CheckGround();
        Jump();
    }
    #endregion

    #region 事件
    /// <summary>
    /// 繪製圖示
    /// 在 Unity 繪製輔助用的圖示
    /// 線條、射線、圓形、方形、扇形、圖片
    /// 圖示 Gizmos 類別
    /// </summary>
    private void OnDrawGizmos()
    {
        // 1.決定圖示顏色
        Gizmos.color = new Color(1, 0, 0.5f, 0.3f);
        // 2.決定繪製圖形
        // 3.transform.position 此物件的世界座標
        Gizmos.DrawSphere(transform.position +
           transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }

    ///<summary>
    /// 檢查是否在地板
    /// </summary>
    private void CheckGround()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position +
           transform.TransformDirection(checkGroundOffset), checkGroundRadius, canJumpLayer);

        //print("地板碰到的物件：" + hit.name );
        isGround = hit;

        //當 不在地板上 勾選
        ani.SetBool(parameterJump, !isGround);
    }

    private void Jump()
    {
        // 如果 在地板上 並且 按下指定按鍵
        if (isGround && Input.GetKeyDown(keyJump))
        {
            // 剛體.添加推力(二為向量)
            rig.AddForce(new Vector2(0, jump));
        }
    }
    #endregion

    #region 方法
    /// <summary>
    /// 1.玩家是否有按移動按鍵 左右方向或A、D
    /// 2.物件移動行為(API)
    /// </summary>

    private void Move()
    {
        // h 值 指定為 輸入.取得軸向(水平軸) - 水平軸代表左右鍵與 AD
        float h = Input.GetAxis("Horizontal");
        // print("玩家左右鍵值：" + h);

        //剛體元件.加速度 = 新 二維向量(h值* 移動速度 , 剛體.加速度.垂直)；
        rig.velocity = new Vector2(h * speed, rig.velocity.y);

        //當 水平直 不等於零 勾選 走路參數
        ani.SetBool(parameterWalk, h != 0);
    }
    
    ///<summary>
    /// 翻面：
    /// h值 小於0 左：角度 y 180
    /// h值 大於0 右：角度 y 0
    /// </summary>
    private void Filp()
    {
        float h = Input.GetAxis("Horizontal");

        // 如果 h值 小於0 左：角度 y 180
        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        // 如果 h值 大於0 右：角度 y 0
        else if (h > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }


    #endregion

}
