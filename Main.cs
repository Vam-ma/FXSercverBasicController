using CitizenFX.Core;
using CitizenFX.Core.Native;
using static CitizenFX.Core.Native.API;
using System;

namespace BasicControllerClient
{
    public class Main : BaseScript
    {
        public Main()
        {
            API.RegisterCommand("Test", new Action(Test), false);
        }
        private void Test()
        {
            Ped player = Game.Player.Character;
            Model[] models = GetAllVehicleModels();
            Random random = new Random();
            int i = random.Next(models.Length);
            World.CreateVehicle(models[i], player.Position);
        }
    }
}
