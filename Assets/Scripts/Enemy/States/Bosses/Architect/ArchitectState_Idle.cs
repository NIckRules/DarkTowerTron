using DarkTowerTron.AI.FSM;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    public class ArchitectState_Idle : State
    {
        // Does nothing. Just sits there while the Controller handles the timer.
        // The BossController.Update() handles the rotation, so we don't need logic here.
    }
}