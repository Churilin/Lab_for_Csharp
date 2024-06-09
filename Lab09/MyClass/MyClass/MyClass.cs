﻿using System;

namespace MyClass
{
    internal class MyClass
    {
        static void Main()
        {
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука", 124, 2013);
            b2.TakeItem();
            b2.Show();
            Book.SetPrice(12);
            b2.Show();

            Item item1 = new Item();
            item1.Show();

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.Show();
        }
    }
}
