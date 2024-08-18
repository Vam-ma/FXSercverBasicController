using CitizenFX.Core;

using static CitizenFX.Core.Native.API;

namespace BasicControllerClient
{
    public class Controller : BaseScript
    {
        [EventHandler("onClientResourceStart")]
        private void OnClientResourceStart(string resourceName)
        {
            if (resourceName != GetCurrentResourceName())
                return;

            Debug.WriteLine("Succes");

        }
    }
}
