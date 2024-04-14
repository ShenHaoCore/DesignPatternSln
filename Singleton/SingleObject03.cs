namespace Singleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    /// <remarks>
    /// <para>多线程Singleton实现</para>
    /// <para>两次判断是比较完美的</para>
    /// </remarks>
    public class SingleObject03
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <remarks>私有构造函数，防止外部实例化</remarks>
        private SingleObject03() { }

        /// <summary>
        /// 
        /// </summary>
        private static volatile SingleObject03? Instance; 
        private static object lockObject = new object();

        public static SingleObject03? GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    lock (lockObject)
                    {
                        if (Instance == null)
                        {
                            Instance = new SingleObject03();
                        }
                    }
                }
                return Instance;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowMessage()
        {
            Console.WriteLine("Hello SingleObject03!");
        }
    }
}
