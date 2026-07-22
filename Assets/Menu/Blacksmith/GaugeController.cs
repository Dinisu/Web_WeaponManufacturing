using UnityEngine;
using UnityEngine.InputSystem;

public class GaugeController : MonoBehaviour
{
    [Header("動く棒")]
    [SerializeField] private RectTransform pointer;

    [Header("ゲージ")]
    [SerializeField] private RectTransform gauge;

    [Header("移動速度")]
    [SerializeField] private float speed = 300f;

    private float direction = 1f;

    private float leftLimit;
    private float rightLimit;

    private bool isMove = true;

    private void Start()
    {
        // ゲージの横幅から移動範囲を計算
        float halfWidth = gauge.rect.width / 2f;

        leftLimit = -halfWidth;
        rightLimit = halfWidth;
    }

    private void Update()
    {
        if (!isMove)
            return;

        MovePointer();
    }

    /// <summary>
    /// ポインターを左右に往復させる
    /// </summary>
    private void MovePointer()
    {
        Vector2 pos = pointer.anchoredPosition;

        pos.x += direction * speed * Time.deltaTime;

        if (pos.x >= rightLimit)
        {
            pos.x = rightLimit;
            direction = -1;
        }
        else if (pos.x <= leftLimit)
        {
            pos.x = leftLimit;
            direction = 1;
        }

        pointer.anchoredPosition = pos;
    }

    public void ResetPointer()
    {
        pointer.anchoredPosition =
            new Vector2(0, pointer.anchoredPosition.y);

        direction = 1;
    }

    /// <summary>
    /// 停止
    /// </summary>
    public void Stop()
    {
        isMove = false;
    }

    /// <summary>
    /// 再開
    /// </summary>
    public void StartMove()
    {
        isMove = true;
    }

    /// <summary>
    /// 現在位置
    /// </summary>
    public float GetPointerPosition()
    {
        return pointer.anchoredPosition.x;
    }
}
