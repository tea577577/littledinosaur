
using UnityEngine;

/// <summary>
/// ����G2D ��V���b����
/// </summary>

public class contreller2D : MonoBehaviour
{
    #region ���G���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 1500)]
    public float jump = 300;
    [Header("�ˬd�a�O�ؤo�P�첾")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("���D����P�i���D�ϼh")]
    public KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;
    [Header("�ʵe�ѼơG�����P���D")]
    public string parameterWalk = "�����}��";
    public string parameterJump = "���D�}��";

    private Rigidbody2D rig;
    [SerializeField]
    /// <summary>
    /// �O�_�b�a�W
    /// </summary>
    private bool isGround;

    private void Start()
    {
        // ������� = ���o����<2D ����>()
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }


    #endregion

    #region ���G�p�H
    private Animator ani;
    /// <summary>
    /// Update �� 60 FPS
    /// �T�w��s�ƥ�G50 FPS
    /// �B�z���z�欰
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

    #region �ƥ�
    /// <summary>
    /// ø�s�ϥ�
    /// �b Unity ø�s���U�Ϊ��ϥ�
    /// �u���B�g�u�B��ΡB��ΡB���ΡB�Ϥ�
    /// �ϥ� Gizmos ���O
    /// </summary>
    private void OnDrawGizmos()
    {
        // 1.�M�w�ϥ��C��
        Gizmos.color = new Color(1, 0, 0.5f, 0.3f);
        // 2.�M�wø�s�ϧ�
        // 3.transform.position �����󪺥@�ɮy��
        Gizmos.DrawSphere(transform.position +
           transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }

    ///<summary>
    /// �ˬd�O�_�b�a�O
    /// </summary>
    private void CheckGround()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position +
           transform.TransformDirection(checkGroundOffset), checkGroundRadius, canJumpLayer);

        //print("�a�O�I�쪺����G" + hit.name );
        isGround = hit;

        //�� ���b�a�O�W �Ŀ�
        ani.SetBool(parameterJump, !isGround);
    }

    private void Jump()
    {
        // �p�G �b�a�O�W �åB ���U���w����
        if (isGround && Input.GetKeyDown(keyJump))
        {
            // ����.�K�[���O(�G���V�q)
            rig.AddForce(new Vector2(0, jump));
        }
    }
    #endregion

    #region ��k
    /// <summary>
    /// 1.���a�O�_�������ʫ��� ���k��V��A�BD
    /// 2.���󲾰ʦ欰(API)
    /// </summary>

    private void Move()
    {
        // h �� ���w�� ��J.���o�b�V(�����b) - �����b�N���k��P AD
        float h = Input.GetAxis("Horizontal");
        // print("���a���k��ȡG" + h);

        //���餸��.�[�t�� = �s �G���V�q(h��* ���ʳt�� , ����.�[�t��.����)�F
        rig.velocity = new Vector2(h * speed, rig.velocity.y);

        //�� ������ ������s �Ŀ� �����Ѽ�
        ani.SetBool(parameterWalk, h != 0);
    }
    
    ///<summary>
    /// ½���G
    /// h�� �p��0 ���G���� y 180
    /// h�� �j��0 �k�G���� y 0
    /// </summary>
    private void Filp()
    {
        float h = Input.GetAxis("Horizontal");

        // �p�G h�� �p��0 ���G���� y 180
        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        // �p�G h�� �j��0 �k�G���� y 0
        else if (h > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }


    #endregion

}
