using DesignPaterns.FactoryPattern.Managers;
using DesignPaterns.FactoryPattern.SimpleFactory;

namespace DesignPaterns.FactoryPattern.Factory
{
    public class SimpleCupsManagerFactory
    {
        public ICupsManager GetCupsManager(int cupsSize)
        {
            ICupsManager cupsSizes = null;
            if(cupsSize == 1)
            {
                return cupsSizes = new SmallCupManager();
            }
            else if (cupsSize == 2)
            {
                return cupsSizes = new MeduimCupManager();
            }
            return cupsSizes;
        }
    }
}
