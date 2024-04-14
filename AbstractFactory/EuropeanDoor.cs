namespace AbstractFactory
{
    /// <summary>
    /// 欧式的房门
    /// </summary>
    public class EuropeanDoor : Door
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的房门");
        }
    }
}
