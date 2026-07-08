using App.BaseSystem.DataStores.ScriptableObjects.Status;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private Image rarityColor;

    /// <summary>
    /// アイテム画像の表示場所
    /// </summary>
    public void SetIcon(Sprite sprite)
    {
        itemImage.sprite = sprite;
    }

    /// <summary>
    /// レア度ごとの色設定（呼び出し用）
    /// </summary>
    public void SetItem(Sprite sprite, Rarity rarity)
    {
        itemImage.sprite = sprite;
        SetRarityColor(rarity);
    }

    /// <summary>
    /// レア度ごとの色設定（処理部分）
    /// </summary>
    private void SetRarityColor(Rarity rarity)
    {
        switch (rarity)
        {
            case Rarity.Common:
                rarityColor.color = Color.white;
                break;

            case Rarity.Uncommon:
                rarityColor.color = Color.green;
                break;

            case Rarity.Rare:
                rarityColor.color = Color.blue;
                break;

            case Rarity.Epic:
                rarityColor.color = new Color(0.7f, 0f, 1f); // 紫
                break;

            case Rarity.Legendary:
                rarityColor.color = new Color(1f, 0.6f, 0f); // オレンジ
                break;
        }
    }
}