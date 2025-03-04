using FireEmblem3H.Content.Items.Materials;
using FireEmblem3H.Content.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FireEmblem3H.Content.Items.Accessory
{
    public class Blaidydd : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.width = 35;
            Item.height = 35;

            Item.rare = ItemRarityID.Purple;
            Item.value = 5000000;

            Item.accessory = true;
        }

        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.GetModPlayer<Jugador>().Blaiddyd = true;
        }

        public override bool CanEquipAccessory(Terraria.Player player, int slot, bool modded)
        {
            return !player.GetModPlayer<Jugador>().Blaiddyd;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.GetInstance<CrestStone>())
                .AddTile(ModContent.GetInstance<DragonForgeTile>())
                .Register();
        }
    }
}
