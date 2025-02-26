using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FireEmblem3H.Content.Items.Materials
{
    public class CrestStone : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.width = 80;
            Item.height = 80;

            Item.maxStack = 999;

            Item.rare = ItemRarityID.Red;
            Item.value = 1000000;
        }
    }
}
