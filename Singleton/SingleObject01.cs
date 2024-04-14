namespace Singleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    /// <remarks>
    /// <para>经典单例模式实现</para>
    /// <para>来加载到内存后就是实例化一个单例，简单实用，推荐使用</para>
    /// <para>缺点：无论是否用到，类装载的时候完成实例化</para>
    /// </remarks>
    public class SingleObject01
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <remarks>私有构造函数，防止外部实例化</remarks>
        private SingleObject01() { }

        /// <summary>
        /// 创建 SingleObject 的一个对象
        /// </summary>
        private static SingleObject01 Instance = new SingleObject01();

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <returns>获取唯一可用的对象</returns>
        public static SingleObject01 GetInstance()
        {
            return Instance;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowMessage()
        {
            Console.WriteLine("Hello SingleObject01!");
        }
    }
}
