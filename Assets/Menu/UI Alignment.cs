using UnityEngine;

public class UIAlignment : MonoBehaviour//　没、本当に使わないなら削除する
{
    [SerializeField] private float horizontalSpacing = 2.0f; // 横の間隔
    [SerializeField] private float verticalSpacing = 1.0f;   // 縦の間隔
    [SerializeField] private Vector2 startPosition = Vector2.zero; // 配置開始位置（親オブジェクトの相対座標）

    [SerializeField] private int columnCount = 6; //列の数

    /// <summary>
    /// このスクリプトの子オブジェクトを整列させる
    /// </summary>
    public void ArrangeChildren()
    {
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);

            int column = i % columnCount;
            int row = i / columnCount;

            float x = startPosition.x + (column * horizontalSpacing);
            float y = startPosition.y - (row * verticalSpacing);

            child.localPosition = new Vector3(x, y, 0);
        }
    }
}
