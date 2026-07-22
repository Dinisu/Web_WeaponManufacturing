using UnityEngine;

public class SuccessAreaController : MonoBehaviour
{
    [Header("ゲージ")]
    [SerializeField] private RectTransform gauge;

    [Header("成功エリア")]
    [SerializeField] private RectTransform successArea;

    [Header("大成功エリア")]
    [SerializeField] private RectTransform greatArea;

    [Header("成功エリアサイズ")]
    [SerializeField] private float minSuccessWidth = 150f;
    [SerializeField] private float maxSuccessWidth = 250f;

    [Header("大成功エリアサイズ")]
    [SerializeField] private float minGreatWidth = 40f;
    [SerializeField] private float maxGreatWidth = 80f;

    //成功の現在の範囲を取得できるように
    public float SuccessLeft => successArea.anchoredPosition.x - successArea.rect.width / 2;
    public float SuccessRight => successArea.anchoredPosition.x + successArea.rect.width / 2;

    //大成功の現在の範囲を取得できるように
    public float GreatLeft => greatArea.anchoredPosition.x - greatArea.rect.width / 2;
    public float GreatRight => greatArea.anchoredPosition.x + greatArea.rect.width / 2;

    private void Start()
    {
        CreateArea();
    }

    /// <summary>
    /// 成功エリアをランダム生成
    /// </summary>
    public void CreateArea()
    {
        float gaugeWidth = gauge.rect.width;

        //------------------------
        // 成功エリア
        //------------------------

        float successWidth =
            Random.Range(minSuccessWidth, maxSuccessWidth);

        successArea.sizeDelta =
            new Vector2(successWidth, successArea.sizeDelta.y);

        float successX =
            Random.Range(
                -gaugeWidth / 2 + successWidth / 2,
                 gaugeWidth / 2 - successWidth / 2);

        successArea.anchoredPosition =
            new Vector2(successX, successArea.anchoredPosition.y);

        //------------------------
        // 大成功エリア
        //------------------------

        float greatWidth =
            Random.Range(minGreatWidth, maxGreatWidth);

        greatArea.sizeDelta =
            new Vector2(greatWidth, greatArea.sizeDelta.y);

        float left =
            successX - successWidth / 2 + greatWidth / 2;

        float right =
            successX + successWidth / 2 - greatWidth / 2;

        float greatX =
            Random.Range(left, right);

        greatArea.anchoredPosition =
            new Vector2(greatX, greatArea.anchoredPosition.y);
    }
}
