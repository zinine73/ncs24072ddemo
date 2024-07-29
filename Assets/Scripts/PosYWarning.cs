using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Myevan;

public class PosYWarning : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro logText = null;

    public float posY;
    public string goName;

    // Start is called before the first frame update
    void Start()
    {
        if (goName == "")
            goName = name;
    }

    // Update is called once per frame
    void Update()
    {
        // GameObject가 posY 를 넘어가면 Warning메시지를 출력한다
        if (transform.position.y > posY)
        {
            string chajosa = Korean.ReplaceJosa($"{goName}(탕)후루");
            Debug.LogWarning($"{chajosa} {posY}를 넘어갔습니다");
            logText.text = $"{chajosa} {posY}를 넘어갔습니다";
        }
    }
}
