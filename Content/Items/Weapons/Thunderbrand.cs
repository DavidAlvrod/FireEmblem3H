using FireEmblem3H.Content.Items.Materials;
using FireEmblem3H.Content.Tiles;
using System;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FireEmblem3H.Content.Items.Weapons
{
    public class Thunderbrand : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.damage = 200;
            Item.DamageType = DamageClass.Melee;
            Item.crit = 6;
            Item.knockBack = 10;

            Item.width = 50;
            Item.height = 50;
            Item.scale = 1.5f;

            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.useTurn = true;

            Item.rare = ItemRarityID.Purple;
            Item.value = 5000000;
        }

        public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
        {
            if (player.GetModPlayer<Jugador>().Charon)
            {
                damage *= 1.5f;
            }
        }

        public override void ModifyWeaponCrit(Player player, ref float crit)
        {
            if (player.GetModPlayer<Jugador>().Charon)
            {
                crit += 30;
            }
        }

        public override void UseAnimation(Player player)
        {
            player.GetModPlayer<Jugador>().checkCrest();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.GetInstance<DragonBone>(), 206)
                .AddIngredient(ModContent.GetInstance<CrestStone>())
                .AddTile(ModContent.GetInstance<DragonForgeTile>())
                .Register();
        }
    }
}
