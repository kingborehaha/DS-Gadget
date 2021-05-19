using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DS_Gadget
{
    class DSItemCategory
    {
        public string Name;
        public int ID;
        public List<DSItem> Items;

        private DSItemCategory(string name, int id, string itemList, bool showIDs)
        {
            Name = name;
            ID = id;
            Items = new List<DSItem>();
            foreach (string line in Regex.Split(itemList, "[\r\n]+"))
            {
                if (GetTxtResourceClass.IsValidTxtResource(line)) //determine if line is a valid resource or not
                    Items.Add(new DSItem(line, showIDs));
            };
            Items.Sort();
        }

        public override string ToString()
        {
            return Name;
        }

        public static List<DSItemCategory> All = new List<DSItemCategory>()
        {
            new DSItemCategory("Armor", 0x10000000, GetTxtResourceClass.GetTxtResource("Resources/Items/Armor.txt"), false),
            new DSItemCategory("Consumables", 0x40000000, GetTxtResourceClass.GetTxtResource("Resources/Items/Consumables.txt"), false),
            new DSItemCategory("Key Items", 0x40000000, GetTxtResourceClass.GetTxtResource("Resources/Items/KeyItems.txt"), false),
            new DSItemCategory("Melee Weapons", 0x00000000, GetTxtResourceClass.GetTxtResource("Resources/Items/MeleeWeapons.txt"), false),
            new DSItemCategory("Ranged Weapons", 0x00000000, GetTxtResourceClass.GetTxtResource("Resources/Items/RangedWeapons.txt"), false),
            new DSItemCategory("Rings", 0x20000000, GetTxtResourceClass.GetTxtResource("Resources/Items/Rings.txt"), false),
            new DSItemCategory("Shields", 0x00000000, GetTxtResourceClass.GetTxtResource("Resources/Items/Shields.txt"), false),
            new DSItemCategory("Spells", 0x40000000, GetTxtResourceClass.GetTxtResource("Resources/Items/Spells.txt"), false),
            new DSItemCategory("Spell Tools", 0x00000000, GetTxtResourceClass.GetTxtResource("Resources/Items/SpellTools.txt"), false),
            new DSItemCategory("Upgrade Materials", 0x40000000, GetTxtResourceClass.GetTxtResource("Resources/Items/UpgradeMaterials.txt"), false),
            new DSItemCategory("Usable Items", 0x40000000, GetTxtResourceClass.GetTxtResource("Resources/Items/UsableItems.txt"), false),
            new DSItemCategory("Mystery Weapons", 0x00000000, GetTxtResourceClass.GetTxtResource("Resources/Items/MysteryWeapons.txt"), true),
            new DSItemCategory("Mystery Armor", 0x10000000, GetTxtResourceClass.GetTxtResource("Resources/Items/MysteryArmor.txt"), true),
            new DSItemCategory("Mystery Goods", 0x40000000, GetTxtResourceClass.GetTxtResource("Resources/Items/MysteryGoods.txt"), true),
        };

    }
}
