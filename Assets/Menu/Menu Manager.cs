using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Banner;
    [SerializeField, Header("•\¦”wŒi")]
    private List<BackgroundData> backgrounds;
    [SerializeField] private GameObject data_UI;

    /// <summary>
    /// •\¦”wŒi‚Ìí—Ş
    /// </summary>
    public enum BackgroundType
    {
        Battle,
        Blacksmith
    }

    [System.Serializable]

    public class BackgroundData//•\¦”wŒi‚ÌŠÇ—ƒNƒ‰ƒX
    {
        public BackgroundType type;       //í—Ş
        public GameObject background;     //”wŒi
        public GameObject displayFields;  //ƒAƒCƒeƒ€‚È‚Ç‚ğ•\¦‚·‚éêŠ
    }

    /// <summary>
    /// í“¬‰æ–Ê‚ÉˆÚs
    /// </summary>
    public void Next_Battle()
    {
        foreach (var data in backgrounds)
        {
            if (data.type == BackgroundType.Battle)
            {
                data.background.SetActive(true);
            }
            else
            {
                data.background.SetActive(false);
            }
        }
    }

    /// <summary>
    /// ’b–è‰æ–Ê‚ÉˆÚs
    /// </summary>
    public void Next_Blacksmit()
    {
        foreach (var data in backgrounds)
        {
            if (data.type == BackgroundType.Blacksmith)
            {
                data.background.SetActive(true);
            }
            else
            {
                data.background.SetActive(false);
            }
        }
    }
}
