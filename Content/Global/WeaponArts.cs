using System;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using FireEmblem3H.Content.Items.Accessory;

namespace FireEmblem3H.Content.Global
{
    public class SwordArts : GlobalItem
    {
        public int swordArt { get => swordArt; set => swordArt = value; }

        public override bool AppliesToEntity(Item item, bool lateInstantiation)
        {
            if (item.type == ModContent.ItemType<Charon>())
            {
                return true;
            }
            switch (item.type)
            {
                case 1:
                    return true;
                default:
                    return false;
            }
        }
    }
}
