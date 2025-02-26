using FireEmblem3H.Content.Items.Materials;
using FireEmblem3H.Content.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FireEmblem3H.Content.Items.Materials
{
    public class DragonBone : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.maxStack = 999;

            Item.rare = ItemRarityID.Red;
            Item.value = 1000000;
        }
    }
}
