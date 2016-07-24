namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank, IMachine
    {
        private const double initialHealtPoints = 100;
        private const double defencePointsChange = 30;
        private const double attackPointsChange = 40;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, initialHealtPoints)
        {
            this.ToggleDefenseMode();
            //TODO start defense mode
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode)
            {
                this.AttackPoints -= attackPointsChange;
                this.DefensePoints += defencePointsChange;
            }
            else
            {
                this.AttackPoints += attackPointsChange;
                this.DefensePoints -= defencePointsChange;
            }
        }
        public override string ToString()
        {
            var baseString= base.ToString();
            var result = new StringBuilder();

            result.Append(baseString);
            result.Append(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));
            return result.ToString();
        }
    }
}
