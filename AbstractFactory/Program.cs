// 哥哥的欧式风格的房子
using AbstractFactory;

AbstractFactory01 europeanFactory = new EuropeanFactory();
europeanFactory.CreateRoof().Create();
europeanFactory.CreateFloor().Create();
europeanFactory.CreateWindow().Create();
europeanFactory.CreateDoor().Create();


//弟弟的现代风格的房子
AbstractFactory01 modernizationFactory = new ModernizationFactory();
modernizationFactory.CreateRoof().Create();
modernizationFactory.CreateFloor().Create();
modernizationFactory.CreateWindow().Create();
modernizationFactory.CreateDoor().Create();
Console.Read();
