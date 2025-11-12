using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // 确保组件存在
public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 10;
    
    private Rigidbody rb;
    private Vector3 moveVelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 获取WASD输入
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        
        // 计算移动方向
        Vector3 moveInput = new(inputHorizontal, 0, inputVertical);
        moveVelocity = moveInput.normalized * moveSpeed;
    }
    
    // 物理更新，用于处理刚体移动
    void FixedUpdate()
    {
        // 应用移动速度到刚体
        rb.linearVelocity = moveVelocity;
    }
}
