using System.Threading.Tasks;
using System.Collections;

namespace FPSKit
{
    public interface IBaseFeature
    {
        public abstract Task LoadFeature();
        public abstract Task SaveFeature();

        public abstract IEnumerator BootGame();
        public abstract void StartFeature();
        public abstract void StopFeature();

    }
}