using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Banner;
    [SerializeField, Header("ï\é¶îwåi")]
    private GameObject Battle_Background;
    

    public void Next_Battle()
    {
        Battle_Background.SetActive(true);
    }

}
