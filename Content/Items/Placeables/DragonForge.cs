using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FireEmblem3H.Content.Items.Placeables
{
    public class DragonForge : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.createTile = ModContent.TileType<Tiles.DragonForgeTile>();

            Item.width = 32; // The item texture's width
            Item.height = 32; // The item texture's height

            Item.useTurn = true;
            Item.autoReuse = true;

            Item.useStyle = ItemUseStyleID.Swing;

            Item.useTime = 10;
            Item.useAnimation = 15;
            Item.consumable = true;

            Item.maxStack = 99;

            Item.value = 150;
            Item.rare = ItemRarityID.Red;
        }
    }
}
