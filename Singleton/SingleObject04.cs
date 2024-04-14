namespace Singleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    /// <remarks>
    /// <para>静态Singleton实现</para>
    /// </remarks>
    public class SingleObject04
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <remarks>私有构造函数，防止外部实例化</remarks>
        private SingleObject04() { }

        public static readonly SingleObject04 Instance = new SingleObject04();

        /// <summary>
        /// 
        /// </summary>
        public void ShowMessage()
        {
            Console.WriteLine("Hello SingleObject04!");
        }
    }
}
