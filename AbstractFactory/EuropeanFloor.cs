namespace AbstractFactory
{
    /// <summary>
    /// 欧式地板类
    /// </summary>
    public class EuropeanFloor : Floor
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的地板");
        }
    }
}
