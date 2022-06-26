using Platformer.Core;
using Platformer.Mechanics;
using UnityEngine;

namespace Platformer.Gameplay
{
    public class CoinCollect : Simulation.Event<PlayerJumped>
    {
        public CollectItem coin;

        public override void Execute()
        {
            if (coin.audioSource && coin.collectClip)
            {
                coin.audioSource.PlayOneShot(coin.collectClip);
                coin.gameObject.transform.position += Vector3.down * 100;
                
            }
        }
    }
}