﻿namespace AbstractFactory
{
    /// <summary>
    /// 古典的地板
    /// </summary>
    public class ClassicalFloor : Floor
    {
        public override void Create()
        {
            Console.WriteLine("创建古典的地板");
        }
    }
}
