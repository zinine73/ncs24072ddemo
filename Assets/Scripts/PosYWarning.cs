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
        // GameObject�� posY �� �Ѿ�� Warning�޽����� ����Ѵ�
        if (transform.position.y > posY)
        {
            string chajosa = Korean.ReplaceJosa($"{goName}(��)�ķ�");
            Debug.LogWarning($"{chajosa} {posY}�� �Ѿ���ϴ�");
            logText.text = $"{chajosa} {posY}�� �Ѿ���ϴ�";
        }
    }
}
