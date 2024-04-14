namespace AbstractFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class EuropeanFactory : AbstractFactory01
    {
        //创建房顶
        public override Roof CreateRoof()
        {
            return new EuropeanRoof();
        }

        // 创建地板
        public override Floor CreateFloor()
        {
            return new EuropeanFloor();
        }

        // 创建窗户
        public override Window CreateWindow()
        {
            return new EuropeanWindow();
        }

        // 创建房门
        public override Door CreateDoor()
        {
            return new EuropeanDoor();
        }
    }
}
