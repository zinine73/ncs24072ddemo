using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D ri2d = null;

    public float startPoint = 0;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�Ϲ����� ���� �˸�");
        Debug.LogWarning("���� �����ؾ� �Ǵ� ����");
        //Debug.LogError("����!!! �ݵ�� �����ϰ� �Ѿ ��!");
    }

    // Update is called once per frame
    void Update()
    {
        // MyAvatar
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        ri2d.velocity = new Vector3(x, y, 0) * moveSpeed;
    }
}
