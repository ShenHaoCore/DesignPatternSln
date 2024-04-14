namespace AbstractFactory
{
    /// <summary>
    /// 抽象工厂类，提供创建不同类型房子的接口
    /// </summary>
    public abstract class AbstractFactory01
    {
        // 抽象工厂提供创建一系列产品的接口，这里作为例子，只给出了房顶、地板、窗户和房门创建接口
        public abstract Roof CreateRoof();
        public abstract Floor CreateFloor();
        public abstract Window CreateWindow();
        public abstract Door CreateDoor();
    }
}
