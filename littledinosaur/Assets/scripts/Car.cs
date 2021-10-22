using UnityEngine;      // �ޥ� Unity �����R�W�Ŷ��G�i�H�ϥΦ��Ŷ��� API

// ������
// 2021 
// class���O�G�@�Ӫ����Ź�
// �y�k�G���O ���O�W�١a ���O���e (���O����) �b
// �����O�n�b Unity ���ϥΥ����~�� MonoBehaviour
// �A���ҬO����X�{�G()�B[]�B�a�b�B<>�B''�B??
public class Car : MonoBehaviour
{
    #region ���y�k�P�|�j�`������
    // ��� Field�G�O�s�U�����������
    // �y�k�G�׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    // �� �|�j�`�������G
    // ��  �ơG�x�s�S���p���I�����t�ƭ� - int
    // �B�I�ơG�x�s�a���p���I�����t�ƭ� - float
    // �r  ��G�x�s��r��T            - string
    // ���L�ȡG�O�P�_ ture�Bfalse      - bool
    // ���׹���
    // �p�H�G��L���O����s���B����� private(�w�]��)
    // ���}�G��L���O�i�H�s���B��  �� public
    // ����ݩ� Attritube
    // �y�k�G�a�ݩʦW�� (��)�b
    // 1.���D Header(�r��)
    // 2.���� Tooltip(�r��)
    // 3.�d�� range(�̤p�ȡB�̤j��) - �ȾA�Ω�ƭ����� int�Bfloat

    [Header("CC��"), Range(500, 5000)]
    public int cc = 1000;
    [Header("���q"), Range(1, 10)]
    public float weight = 3.5f;
    [Header("�~�P�W��"), Tooltip("�o�O���l���~�P�W��")]
    public string brand = "���h";
    [Header("�O�_���ѵ�")]
    public bool hasSkyWindow = true;
    #endregion

    #region Unity ���������
    // �C��B�V�q(�y��)�B����B�C������B����
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCustmo1 = new Color(0, 0, 1);
    public Color colorcustmo2 = new Color(1, 0, 1, 0.5f);
    // �V�q 2 - 4 Vector
    public Vector2 V2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2left = Vector2.left;
    public Vector2 v2Custom = new Vector2(1, 2);
    // ���� Keycode
    public KeyCode keycode;
    public KeyCode keycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keycodeJump = KeyCode.Space;
    // �C������ GameOnject
    public GameObject goCamera;
    public GameObject goCar;
    // ���� Component
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer spr;
    #endregion

    #region �ƥ�G�{�����J�f
    // �}�l�ƥ�G�C������ɰ���@��
    private void Start()
    {
        // �I�s��k�G��k�W��();
        Test();
        Drive80();
        Drive(120);    //�I�s�ɶ�J���٬��G�޼�
        float w99 = ConverWeight(9.9f);
        print("9.9 �ഫ�G" + w99);

        print("���q�ഫ�G" + ConverWeight(weight));
    }
    #endregion

    #region ��k�y�k
    // ��k�G�O�s�{�����e���϶��B�t��k�B���z��
    // �y�k�G�׹��� ���� ��k�W�� (�Ѽ�1�B�Ѽ�2�B...�B�Ѽ�N) �a �{�����e �b
    // void �L�Ǧ^�G�ϥΤ�k�ɤ��|���Ǧ^���
    // �ۭq��k ���|����
    private void Test()
    {
        // ��X(�T��)�B�N�T����X�� Unity �����O Console
        print("���o�٥X�Ӥ@�U���U�ڭn�ݦ��S������");
    }

    private void Drive80()
    {
        print("�}���ɳt�G" + 80);
    }

    //�Ѽƻy�k�G������� �ѼƦW��
    private void Drive(int speed)
    {
        print("�}���ɳt�G" + speed);

    }

    private float ConverWeight(float setWeight)
    {
        return setWeight * 50;
    }
    #endregion
}
