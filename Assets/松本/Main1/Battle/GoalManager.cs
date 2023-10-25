using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public int TouchsingB.goalnum;//クリアに必要な個数
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
        Goaltext.text = TouchsingB.goalnum.ToString("0");

        //goalnumが0になったらクリア関数を呼び出す
        if(TouchsingB.goalnum == 0)
        {
            Clear();
        }
    }

    //クリアしたときの関数
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
    }
}
