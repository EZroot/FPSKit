using System.Collections;
using System.Threading.Tasks;

namespace FPSKit 
{
    public abstract class BaseFeature<T> : BaseController<T>, IBaseFeature where T : BaseData
    {
        public abstract Task LoadFeature();
        public abstract Task SaveFeature();

        public abstract IEnumerator BootGame();
        public abstract void StartFeature();
        public abstract void StopFeature();
    }
}