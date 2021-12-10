using UnityEngine;
using System.Collections;

/// <summary>
/// 認識協同程式
/// </summary>

public class Learn : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Test());  // 啟動協同程序(協同程序())
        StartCoroutine(TestWithLoop());
    }

    //定義協同程序
    //傳回類型 IEnumerator
    private IEnumerator Test()
    {
        print("這是第一段文字訊息");
        yield return new WaitForSeconds(1); //等待秒數
        print("這是第二段文字訊息");
        yield return new WaitForSeconds(2);
        print("這是第三段文字訊息");
    }

    private IEnumerator TestWithLoop()
    {
        for (int i = 0; i < 10; i++)
        {
            print("數字：" + i);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
