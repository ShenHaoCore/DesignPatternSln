namespace AbstractFactory
{
    /// <summary>
    ///先为表弟的房子来建立一个工厂类吧
    /// </summary>
    public class ClassicalFactory : AbstractFactory01
    {
        //创建房顶
        public override Roof CreateRoof()
        {
            return new ClassicalRoof();
        }

        // 创建地板
        public override Floor CreateFloor()
        {
            return new ClassicalFloor();
        }

        // 创建窗户
        public override Window CreateWindow()
        {
            return new ClassicalWindow();
        }

        // 创建房门
        public override Door CreateDoor()
        {
            return new ClassicalDoor();
        }
    }
}
