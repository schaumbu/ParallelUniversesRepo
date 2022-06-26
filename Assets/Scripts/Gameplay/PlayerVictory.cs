using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;

namespace Platformer.Gameplay
{
    public class PlayerVictory : Simulation.Event<PlayerVictory>
    {
        PlatformerModel model = Simulation.GetModel<PlatformerModel>();
        public override void Execute()
        {
            var player = model.player;
            model.virtualCamera.m_Follow = null;
            model.virtualCamera.m_LookAt = null;
            player.controlEnabled = false;
            model.player.animator.SetTrigger("victory");
            Simulation.Schedule<PlayerSpawn>(2);
        }
    }
}