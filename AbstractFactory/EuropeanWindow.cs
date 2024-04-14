namespace AbstractFactory
{
    /// <summary>
    ///欧式的窗户
    /// </summary>
    public class EuropeanWindow : Window
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的窗户");
        }
    }
}
