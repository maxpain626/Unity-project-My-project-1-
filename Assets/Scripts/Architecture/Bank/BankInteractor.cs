using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Architecture
{
    public class BankInteractor : Interactor
    {
        private BankRepository repository;

        public int coins => this.repository.coins;

        public BankInteractor(BankRepository repository)
        {
            this.repository = repository;
        }

        public bool isEnoughCoins(int value)
        {
            return coins >= value;
        }

        public void AddCoins(object sender, int value)
        {
            this.repository.coins += value;
            this.repository.Save();
        }

        public void Spend(object sender, int value)
        {
            this.repository.coins -= value;
            this.repository.Save();
        }
    }
}