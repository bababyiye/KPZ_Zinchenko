using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilder
{
    public class Character
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Outfit { get; set; }
        public List<string> Inventory { get; set; }
        public List<string> Deeds { get; set; }

        public Character()
        {
            Inventory = new List<string>();
            Deeds = new List<string>();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"Body: {BodyType}");
            Console.WriteLine($"Hair: {HairColor}, Eyes: {EyeColor}");
            Console.WriteLine($"Outfit: {Outfit}");
            Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
            Console.WriteLine("Deeds: " + string.Join(", ", Deeds));
            Console.WriteLine();
        }
    }

    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHeight(int height);
        ICharacterBuilder SetBodyType(string type);
        ICharacterBuilder SetHairColor(string color);
        ICharacterBuilder SetEyeColor(string color);
        ICharacterBuilder SetOutfit(string outfit);
        ICharacterBuilder AddItem(string item);
        ICharacterBuilder AddDeed(string deed);
        Character Build();
    }


    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character;

        public HeroBuilder()
        {
            _character = new Character();
        }

        public ICharacterBuilder SetName(string name) { _character.Name = name; return this; }
        public ICharacterBuilder SetHeight(int height) { _character.Height = height; return this; }
        public ICharacterBuilder SetBodyType(string type) { _character.BodyType = type; return this; }
        public ICharacterBuilder SetHairColor(string color) { _character.HairColor = color; return this; }
        public ICharacterBuilder SetEyeColor(string color) { _character.EyeColor = color; return this; }
        public ICharacterBuilder SetOutfit(string outfit) { _character.Outfit = outfit; return this; }
        public ICharacterBuilder AddItem(string item) { _character.Inventory.Add(item); return this; }
        public ICharacterBuilder AddDeed(string deed) { _character.Deeds.Add("Good: " + deed); return this; }

        public Character Build() { return _character; }
    }


    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character;

        public EnemyBuilder()
        {
            _character = new Character();
        }

        public ICharacterBuilder SetName(string name) { _character.Name = name; return this; }
        public ICharacterBuilder SetHeight(int height) { _character.Height = height; return this; }
        public ICharacterBuilder SetBodyType(string type) { _character.BodyType = type; return this; }
        public ICharacterBuilder SetHairColor(string color) { _character.HairColor = color; return this; }
        public ICharacterBuilder SetEyeColor(string color) { _character.EyeColor = color; return this; }
        public ICharacterBuilder SetOutfit(string outfit) { _character.Outfit = outfit; return this; }
        public ICharacterBuilder AddItem(string item) { _character.Inventory.Add(item); return this; }
        public ICharacterBuilder AddDeed(string deed) { _character.Deeds.Add("Evil: " + deed); return this; }

        public Character Build() { return _character; }
    }


    public class Director
    {
        public void CreateHero(ICharacterBuilder builder)
        {
            builder.SetName("Arion")
                   .SetHeight(185)
                   .SetBodyType("Athletic")
                   .SetHairColor("Blonde")
                   .SetEyeColor("Blue")
                   .SetOutfit("Silver Armor")
                   .AddItem("Sword of Light")
                   .AddItem("Healing Potion")
                   .AddDeed("Saved the village")
                   .AddDeed("Defeated the dragon");
        }

        public void CreateEnemy(ICharacterBuilder builder)
        {
            builder.SetName("Mordrak")
                   .SetHeight(200)
                   .SetBodyType("Muscular")
                   .SetHairColor("Black")
                   .SetEyeColor("Red")
                   .SetOutfit("Dark Cloak")
                   .AddItem("Cursed Staff")
                   .AddItem("Poison")
                   .AddDeed("Destroyed the temple")
                   .AddDeed("Stole the ancient relic");
        }
    }

}
