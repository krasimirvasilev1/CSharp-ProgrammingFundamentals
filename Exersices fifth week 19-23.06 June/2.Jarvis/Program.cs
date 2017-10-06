using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Jarvis
{
    class Arms
    {
        public int EnergyConsumption { get; set; }
        public int ReachDistance { get; set; }
        public int CountOfFingers { get; set; }
    }
    class Legs
    {
        public int EnergyConsumption { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
    }
    class Torso
    {
        public int EnergyConsumption { get; set; }
        public double ProcessorSizeInCentimetres { get; set; }
        public string HousingMaterial { get; set; }
    }
    class Head
    {
        public int EnergyConsumption { get; set; }
        public int IQ { get; set; }
        public string SkinMaterial { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Head> partHead = new List<Head>();
            List<Arms> partArms = new List<Arms>();
            List<Legs> partLegs = new List<Legs>();
            List<Torso> partTorso = new List<Torso>();

            long jarvisEnergy = long.Parse(Console.ReadLine());

            var continueAddingParts = true;
            var counterForArms = 0;
            var counterForLegs = 0;
            while (continueAddingParts)
            {
                var componentsOfBody = Console.ReadLine().Split().ToArray();
                var typeOfBodyPart = componentsOfBody[0];
                if (typeOfBodyPart == "Assemble!")
                {
                    continueAddingParts = false;
                    break;
                }
                var energyConsumption = componentsOfBody[1];
                var propertyOne = componentsOfBody[2];
                var propertyTwo = componentsOfBody[3];

                if (typeOfBodyPart == "Head")
                {
                    Head addingHead = new Head
                    {
                        EnergyConsumption = int.Parse(energyConsumption),
                        IQ = int.Parse(propertyOne),
                        SkinMaterial = propertyTwo
                    };
                    if (partHead.Count != 1)
                    {
                        partHead.Add(addingHead);
                    }
                    else
                    {
                        if (partHead[0].EnergyConsumption > addingHead.EnergyConsumption)
                        {
                            partHead[0] = addingHead;
                        }
                    }
                }
                else if (typeOfBodyPart == "Torso")
                {
                    Torso addingTorso = new Torso
                    {
                        EnergyConsumption = int.Parse(energyConsumption),
                        ProcessorSizeInCentimetres = double.Parse(propertyOne),
                        HousingMaterial = propertyTwo
                    };
                    if (partTorso.Count != 1)
                    {
                        partTorso.Add(addingTorso);
                    }
                    else
                    {
                        if (partTorso[0].EnergyConsumption > addingTorso.EnergyConsumption)
                        {
                            partTorso[0] = addingTorso;
                        }
                    }
                }
                else if (typeOfBodyPart == "Arm")
                {

                    Arms addingArms = new Arms
                    {
                        EnergyConsumption = int.Parse(energyConsumption),
                        ReachDistance = int.Parse(propertyOne),
                        CountOfFingers = int.Parse(propertyTwo)
                    };
                    if (partArms.Count != 2)
                    {
                        partArms.Add(addingArms);

                    }
                    else if (partArms.Count == 2 && partArms[0].EnergyConsumption > addingArms.EnergyConsumption &&
                        partArms[1].EnergyConsumption > addingArms.EnergyConsumption)
                    {
                        partArms[0] = addingArms;
                        partArms.Reverse();

                    }
                    else if (partArms.Count == 2 && partArms[0].EnergyConsumption > addingArms.EnergyConsumption)
                    {
                        partArms[0] = addingArms;
                    }
                    else if (partArms[1].EnergyConsumption > addingArms.EnergyConsumption)
                    {
                        partArms[1] = addingArms;
                    }
                }
                else if (typeOfBodyPart == "Leg")
                {
                    Legs addingLegs = new Legs
                    {
                        EnergyConsumption = int.Parse(energyConsumption),
                        Strength = int.Parse(propertyOne),
                        Speed = int.Parse(propertyTwo)
                    };
                    if (partLegs.Count != 2)
                    {
                        partLegs.Add(addingLegs);

                    }
                    else if (partLegs.Count == 2 && partLegs[0].EnergyConsumption > addingLegs.EnergyConsumption &&
                        partLegs[1].EnergyConsumption > addingLegs.EnergyConsumption)
                    {
                        partLegs[0] = addingLegs;
                        partLegs.Reverse();

                    }
                    else if (partLegs.Count == 2 && partLegs[0].EnergyConsumption > addingLegs.EnergyConsumption)
                    {
                        partLegs[0] = addingLegs;
                    }
                    else if (partLegs[1].EnergyConsumption > addingLegs.EnergyConsumption)
                    {
                        partLegs[1] = addingLegs;
                    }
                }
            }

            if (partHead.Count != 1 || partTorso.Count != 1 || partArms.Count != 2 || partLegs.Count != 2)
            {
                Console.WriteLine("We need more parts!");
            }
            else if (jarvisEnergy < (partHead[0].EnergyConsumption + partTorso[0].EnergyConsumption + partArms[0].EnergyConsumption
                + partArms[1].EnergyConsumption + partLegs[0].EnergyConsumption + partLegs[1].EnergyConsumption))
            {

                Console.WriteLine("We need more power!");
            }
           
            else
            {
                partArms = partArms.OrderBy(x => x.EnergyConsumption).ToList();
                partLegs = partLegs.OrderBy(x => x.EnergyConsumption).ToList();

                Console.WriteLine("Jarvis:");
                Console.WriteLine("#Head:");
                Console.WriteLine($"###Energy consumption: {partHead[0].EnergyConsumption}");
                Console.WriteLine($"###IQ: {partHead[0].IQ}");
                Console.WriteLine($"###Skin material: {partHead[0].SkinMaterial}");
                Console.WriteLine("#Torso:");
                Console.WriteLine($"###Energy consumption: {partTorso[0].EnergyConsumption}");
                Console.WriteLine($"###Processor size: {partTorso[0].ProcessorSizeInCentimetres:F1}");
                Console.WriteLine($"###Corpus material: {partTorso[0].HousingMaterial}");
                Console.WriteLine("#Arm:");
                Console.WriteLine($"###Energy consumption: {partArms[0].EnergyConsumption}");
                Console.WriteLine($"###Reach: {partArms[0].ReachDistance}");
                Console.WriteLine($"###Fingers: {partArms[0].CountOfFingers}");
                Console.WriteLine("#Arm:");
                Console.WriteLine($"###Energy consumption: {partArms[1].EnergyConsumption}");
                Console.WriteLine($"###Reach: {partArms[1].ReachDistance}");
                Console.WriteLine($"###Fingers: {partArms[1].CountOfFingers}");
                Console.WriteLine("#Leg:");
                Console.WriteLine($"###Energy consumption: {partLegs[0].EnergyConsumption}");
                Console.WriteLine($"###Strength: {partLegs[0].Strength}");
                Console.WriteLine($"###Speed: {partLegs[0].Speed}");
                Console.WriteLine("#Leg:");
                Console.WriteLine($"###Energy consumption: {partLegs[1].EnergyConsumption}");
                Console.WriteLine($"###Strength: {partLegs[1].Strength}");
                Console.WriteLine($"###Speed: {partLegs[1].Speed}");
            }
        }
    }
}
