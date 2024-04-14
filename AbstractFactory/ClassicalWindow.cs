﻿namespace AbstractFactory
{
    /// <summary>
    /// 古典的窗户
    /// </summary>
    public class ClassicalWindow : Window
    {
        public override void Create()
        {
            Console.WriteLine("创建古典的窗户");
        }
    }
}
