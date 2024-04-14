﻿namespace AbstractFactory
{
    /// <summary>
    /// 古典的房门
    /// </summary>
    public class ClassicalDoor : Door
    {
        public override void Create()
        {
            Console.WriteLine("创建古典的房门");
        }
    }
}
