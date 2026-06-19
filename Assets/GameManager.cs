using System.Collections.Generic;
using UnityEngine;
using App.BaseSystem.DataStores.ScriptableObjects.Status;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //シングルトンの宣言
    public static GameManager Instance = null;

    [Header("所持金")]
    public int PlayerMoney;


    [Header("プレイ時間")]
    public float PlayTime = 0f;

    [Header("決定音、キャンセル")]
    public AudioClip decision;
    public AudioClip cancel;
    public AudioSource audioSource;

    //初期化処理
    private void Awake()
    {
        //シングルトンがあるかどうかのチェック
        if (Instance == null)
        {
            Instance = this;//インスタンスを設定
            DontDestroyOnLoad(this.gameObject);//破棄されないようにする
        }
        else
        {
            Destroy(this.gameObject);//nullでなければ削除
        }

        // AudioSource の用意（Inspector未設定なら取得/追加）
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
        }
    }

    private void Update()
    {
        PlayTime += Time.deltaTime;
    }
}
