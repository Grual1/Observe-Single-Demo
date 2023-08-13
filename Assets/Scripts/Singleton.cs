public class Singleton<T> where T : class, new()
{
    private static T instance;

    // 对外提供访问单例的方法
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }
    }

    // 保护的构造函数，确保无法在类外部创建实例
    protected Singleton() { }
}