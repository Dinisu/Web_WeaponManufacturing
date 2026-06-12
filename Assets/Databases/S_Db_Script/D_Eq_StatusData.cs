using NUnit.Framework.Interfaces;
using System.Collections.Generic;
using UnityEngine;


namespace App.BaseSystem.DataStores.ScriptableObjects.Status
{
    [CreateAssetMenu(menuName = "ScriptableObject/Data/EquipmentStatus")]
    public class D_Eq_StatusData : BaseData
    {

        public enum Rarity
        {
            // コモン、アンコモン、レア、エピック、レジェンダリー
            Common,
            Uncommon,
            Rare,
            Epic,
            Legendary
        }

        public Rarity SeeRarity
        {
            get => rarity;
            set => rarity = value;
        }
        [SerializeField, Header("レア度")]
        private Rarity rarity;

        public enum Attribute
        {
            //上から無、火、水、木、金、土
            None,
            Fire,
            Water,
            Tree,
            Metal,
            Soil,
        }
        public Attribute SeeAttribute//参照時はこれを呼ぶ
        {
            get => attribute;
            set => attribute = value;
        }
        [SerializeField, Header("属性")]
        private Attribute attribute;
        public int MaxHp
        {
            get => maxhp;
            set => maxhp = value;
        }
        [SerializeField, Header("最大耐久度")]
        private int maxhp;

        public int Hp
        {
            get => hp;
            set => hp = Mathf.Clamp(value, 0, maxhp); // 0 <= hp <= maxhp
        }
        //[HideInInspector]
        [SerializeField]
        private int hp;
        public int MaxMp
        {
            get => maxmp;
            set => maxmp = value;
        }
        [SerializeField, Header("最大MP")]
        private int maxmp;

        public int Mp
        {
            get => mp;
            set => mp = Mathf.Clamp(value, 0, maxmp); // 0 <= hp <= maxmp
        }
        [SerializeField]
        private int mp;

        public int Attack
        {
            get => attack;
            set => attack = value;
        }
        [SerializeField, Header("攻撃力")]
        private int attack;

        public int Magic
        {
            get => magic;
            set => magic = value;
        }
        [SerializeField, Header("魔力")]
        private int magic;

        public int Defense
        {
            get => defense;
            set => defense = value;
        }
        [SerializeField, Header("防御力")]
        private int defense;

        public int MagicDefense
        {
            get => magicDefense;
            set => magicDefense = value;
        }
        [SerializeField, Header("魔法防御力")]
        private int magicDefense;

        public int Speed
        {
            get => speed;
            set => speed = value;
        }
        [SerializeField, Header("速度")]
        private int speed;

        public float CriticalRate
        {
            get => criticalRate;
            set => criticalRate = value;
        }
        [SerializeField, Header("クリティカル率")]
        private float criticalRate;

        [SerializeField, Header("アクセサリー1")]
        public D_It_StatusData Accessories1;
        [SerializeField, Header("アクセサリー2")]
        public D_It_StatusData Accessories2;


        [SerializeField, Header("付与スキルリスト")]
        public Db_Sk_StatusDataBase SkillList;

        [SerializeField, Header("受けているスキルバフ")]
        public List<ActiveBuff<D_Sk_StatusData>> ActiveBuffs = new();//スキルバフのデータ管理
        //[HideInInspector]
        [SerializeField, Header("受けているアイテムバフ")]
        public List<ActiveBuff<D_It_StatusData>> ActiveBuffs_It = new();//アイテムバフのデータ管理
        public enum Abnormalstatus
        {
            None
        }

        [SerializeField, Header("外見")]
        public GameObject Character;
        public GameObject B_Character;
        public GameObject B_Icon;
        public GameObject B_Icon_Ch;
        public GameObject Icon_Character1;
        public GameObject Icon_Character2;
    }
}