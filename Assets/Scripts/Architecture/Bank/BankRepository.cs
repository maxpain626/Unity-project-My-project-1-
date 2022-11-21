using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Architecture
{
    public class BankRepository : Repository
    {
        private const string KEY = "BANK_KEY";

        public int coins { get; set; }

        public override void Initialize()
        {
            this.coins = PlayerPrefs.GetInt(KEY, defaultValue: 0);
        }
        public override void Save()
        {
            PlayerPrefs.SetInt(KEY, this.coins);
        }
    }
}