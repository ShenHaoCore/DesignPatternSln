namespace AbstractFactory
{
    /// <summary>
    /// 现代的房门
    /// </summary>
    public class ModernizationDoor : Door
    {
        public override void Create()
        {
            Console.WriteLine("创建现代的房门");
        }
    }
}
