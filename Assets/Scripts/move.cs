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
        Debug.Log("일반적인 정보 알림");
        Debug.LogWarning("뭔가 주의해야 되는 내용");
        //Debug.LogError("에러!!! 반드시 수정하고 넘어갈 것!");
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
