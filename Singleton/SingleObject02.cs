namespace Singleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    /// <remarks>
    /// <para>单线程Singleton实现</para>
    /// <para>多线程会出现问题</para>
    /// </remarks>
    public class SingleObject02
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <remarks>私有构造函数，防止外部实例化</remarks>
        private SingleObject02() { }

        /// <summary>
        /// 创建 SingleObject 的一个对象
        /// </summary>
        private static SingleObject02? instance = null;

        /// <summary>
        /// 获取对象
        /// </summary>
        public static SingleObject02? GetInstance
        {
            get
            {
                if (instance == null) { instance = new SingleObject02(); }
                return instance;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowMessage()
        {
            Console.WriteLine("Hello SingleObject02!");
        }
    }
}
