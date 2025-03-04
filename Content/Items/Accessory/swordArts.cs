using FireEmblem3H.Content.Items.Materials;
using FireEmblem3H.Content.Tiles;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FireEmblem3H.Content.Items.Accessory
{
    public class wrathStrike : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.width = 25;
            Item.height = 25;

            Item.rare = ItemRarityID.Purple;
            Item.value = 5000000;

            Item.accessory = true;
        }

        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            if (slot == 0)
            {
                return true;
            }
            return false;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<Jugador>().SwordArt = 1;
        }
    }

    public class grounder : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.width = 15;
            Item.height = 15;

            Item.rare = ItemRarityID.Purple;
            Item.value = 5000000;

            Item.accessory = true;
        }

        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            if (slot == 0)
            {
                return true;
            }
            return false;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<Jugador>().SwordArt = 2;
        }
    }
}
