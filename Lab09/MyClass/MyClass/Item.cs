﻿using System;

namespace MyClass
{
    internal class Item
    {
        protected long invNumber;
        protected bool taken;

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public Item()
        {
            this.taken = true;
        }

        public bool IsAvailable()
        {
            if (taken == true) return true;
            else return false;
        }
        public long GetInvNumber()
        {
            return invNumber;
        }
        public void Take()
        {
            taken = false;
        }
        public void Return()
        {
            taken = true;
        }
        private void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }
        public void Show()
        {
            Console.WriteLine("Состояние единицы хранения:\n Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken);
        }
    }
}