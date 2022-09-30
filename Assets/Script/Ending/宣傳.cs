using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 宣傳 : MonoBehaviour
{
    public Text A;
    public string[] Strings;
    int len = 3;

    [Header("Image")]
    public Texture2D[] Photos;
    public Texture2D introduce;
    public Texture2D Ai;
    public Texture2D Fast;
    public Texture2D TwentyS;
    public Texture2D ninetyPrecent;
    public Texture2D diagnosing;
    public Texture2D Smart;
    [Header("Text")]
    public string[] Content;
    [Header("Odject")]
    public GameObject image_1587_2245;
    public GameObject image_717_717;
    public GameObject text;
    public int Frame = 0;
    int max = 5;

    public void Set0()
    {
        image_717_717.GetComponent<RawImage>().texture = Photos[0];
        text.GetComponent<Text>().text = Content[0];
        Frame = 0;
    }

    public void Pass2NextFrame()
    {
        if (Frame >= max)
        {
            Frame = 0;
        }
        else
        {
            Frame++;
        }
        Setting();
    }

    public void 廣告()
    {
        int z = UnityEngine.Random.Range(0, len - 1);
        A.GetComponent<Text>().text = Strings[z];
    }

    public void Setting()
    {
        if (Frame == 1)
        {
            image_1587_2245.SetActive(false);
            image_717_717.SetActive(true);
            text.GetComponent<Text>().text = Content[0];
        }
        else if (Frame == 1)
        {
            image_1587_2245.SetActive(true);
            image_717_717.SetActive(false);
            image_1587_2245.GetComponent<RawImage>().texture = Photos[1];
            text.GetComponent<Text>().text = Content[1];
        }
        else if (Frame == 2)
        {
            image_1587_2245.SetActive(true);
            image_717_717.SetActive(false);
            image_1587_2245.GetComponent<RawImage>().texture = Photos[2];
            text.GetComponent<Text>().text = Content[2];
        }
        else if (Frame == 3)
        {
            image_1587_2245.SetActive(true);
            image_717_717.SetActive(false);
            image_1587_2245.GetComponent<RawImage>().texture = Photos[3];
            text.GetComponent<Text>().text = Content[3];
        }
        else if (Frame == 4)
        {
            image_1587_2245.SetActive(true);
            image_717_717.SetActive(false);
            image_1587_2245.GetComponent<RawImage>().texture = Photos[4];
            text.GetComponent<Text>().text = Content[4];
        }
        else if (Frame == 5)
        {
            image_1587_2245.SetActive(true);
            image_717_717.SetActive(false);
            image_1587_2245.GetComponent<RawImage>().texture = Photos[5];
            text.GetComponent<Text>().text = Content[5];
        }
    }

    public void Back2NextFrame()
    {
        if (Frame <= 0)
        {
            Frame = max;
        }
        else
        {
            Frame--;
        }
        Setting();
    }

    // Start is called before the first frame update
    void Start()
    {
        Strings = new string[len];
        Strings[0] = "這個人工智能技術可在20秒內高效區分新冠肺炎與其他病毒性肺炎並可預測危重等級，且準確率高達90%以上，相當於一個省級三甲醫院影像學副教授的診斷水準。";
        Strings[1] = "這個人工智能技術能有效緩解內地醫療物資及人力的巨大壓力。";
        Strings[2] = "這個遊戲是根據澳門科技大學張康教授的基於人工智慧的新型冠狀病毒SARS-CoV-2感染的診斷核心關鍵技術的科研項目進行開發。";

        //KnowMore Image
        Photos = new Texture2D[max + 1];
        Photos[0] = introduce;
        Photos[1] = Fast;
        Photos[2] = TwentyS;
        Photos[3] = ninetyPrecent;
        Photos[4] = Smart;
        Photos[5] = diagnosing;

        //KnowMore Content
        Content = new string[max + 1];
        Content[0] = "基於人工智能的新型冠狀病毒SARS-CoV-2感染 的診斷核心關鍵技術 \n \n申請實體:澳門科技大學 \n項目負責人:張康講座教授 \n項目主要成員:霍文遜院長 李志焕博士";
        Content[1] = "整合CT影像信息和臨床其他數據\n利用深度學習技術開發了新冠肺炎AI診斷模型 ";
        Content[2] = "可在20秒內高效區分新冠肺炎與其他病毒性肺炎並可預測危重等級";
        Content[3] = "且準確率高達90%以上\n相當於一個省級三甲醫院影像學副教授的診斷水準";
        Content[4] = "準確快速地區分新冠肺炎及其他類型肺炎\n例如：肺部彌漫性病變特徵";
        Content[5] = "有效整合醫療資源\n可以改善偏遠地區的醫療資源不足的情況";

        Unbreakable.Round++;

        廣告(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
