using FireEmblem3H.Content.Items.Materials;
using FireEmblem3H.Content.Tiles;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace FireEmblem3H.Content.Items.Accessory
{
    [AutoloadEquip(EquipType.Wings)]
    public class DragonWings :ModItem
    {
        public override void SetStaticDefaults()
        {
            ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new WingStats(210, 9.5f, 2.5f);
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;

            Item.rare = ItemRarityID.Purple;
            Item.value = 5000000;
            
            Item.accessory = true;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f; // Falling glide speed
            ascentWhenRising = 0.15f; // Rising speed
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.135f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.GetInstance<CrestStone>())
                .AddIngredient(ModContent.GetInstance<DragonBone>(), 30)
                .AddTile(ModContent.GetInstance<DragonForgeTile>())
                .Register();
        }
    }
}
