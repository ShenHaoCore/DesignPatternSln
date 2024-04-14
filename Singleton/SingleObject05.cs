namespace Singleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public sealed class SingleObject05
    {
        private static readonly Lazy<SingleObject05> lazyInstance = new Lazy<SingleObject05>(() => new SingleObject05());

        /// <summary>
        /// 构造函数
        /// <para>私有构造函数，防止外部实例化</para>
        /// </summary>
        private SingleObject05() { }

        /// <summary>
        /// 
        /// </summary>
        public static SingleObject05 Instance
        {
            get { return lazyInstance.Value; }
        }
    }
}
