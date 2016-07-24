namespace WarMachines.Machines
{
    using Common;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Pilot name cannot be null or empty");
                this.name = value;
            }
        }
        

        public void AddMachine(IMachine machine)
        {

            Validator.CheckIfNull(machine, "Machine cannot be null or empty");
            this.machines.Add(machine);

        }

        public string Report()
        {
            var sortedMachines = this.machines.OrderBy(x => x.HealthPoints).ThenBy(x => x.Name);
            var machineOrNo = this.machines.Count > 0 ? this.machines.Count.ToString() : "no";
            var oneOrMoreMachines = this.machines.Count == 1 ? "machine" : "machines";

            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} {2}",this.Name,machineOrNo,oneOrMoreMachines));

            foreach (var item in sortedMachines)
            {
                result.AppendLine(item.ToString());
            }
            return result.ToString().Trim();
        }
    }
}
