namespace AbstractFactory
{
    /// <summary>
    /// 现代的房顶
    /// </summary>
    public class ModernizationRoof : Roof
    {
        public override void Create()
        {
            Console.WriteLine("创建现代的房顶");
        }
    }
}
