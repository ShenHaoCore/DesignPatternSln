﻿namespace AbstractFactory
{
    /// <summary>
    ///古典的房顶
    /// </summary>
    public class ClassicalRoof : Roof
    {
        public override void Create()
        {
            Console.WriteLine("创建古典的房顶");
        }
    }
}
