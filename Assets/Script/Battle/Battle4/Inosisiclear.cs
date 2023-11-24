using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Inosisiclear : MonoBehaviour
{
    public string sceneName;//読み込むシーン名
    public Text Goaltext;//クリア個数テキスト

    // Start is called before the first frame update
    void Start()
    {
        Goaltext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //目標個数表示
        Goaltext.text = Isirusi.Iclearnum.ToString("0");

        //goalnumが0になったらクリア関数を呼び出す
        if (Isirusi.Iclearnum == 0)
        {
            Clear();
        }
    }
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.Battele4_1Flg = true;
    }
}
