using FireEmblem3H.Content.Items.Materials;
using FireEmblem3H.Content.Tiles;
using System;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.ModLoader.IO;
using FireEmblem3H.Content.Global;

namespace FireEmblem3H.Content.Items.Weapons
{
    public class Thunderbrand : ModItem
    {

        public static readonly int MaxUses = 300;

        public int useCount;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MaxUses);

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

            Item.consumable = true;

            Item.autoReuse = true;
            Item.useTurn = true;
            ItemID.Sets.ItemsThatAllowRepeatedRightClick[Item.type] = true;

            Item.rare = ItemRarityID.Purple;
            Item.value = 5000000;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
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
            if (player.altFunctionUse == 2)
            {
                Item.useStyle = ItemUseStyleID.Swing;
                Item.shootSpeed = 15f;
                Item.damage = 400;
                if (player.GetModPlayer<Jugador>().Charon)
                {
                    Item.shoot = ProjectileID.StarWrath;
                    Item.ArmorPenetration = 10;
                }
                else
                {
                    switch (player.GetModPlayer<Jugador>().SwordArt)
                    {
                        case int swart
                        when swart == 1:
                            Item.shoot = ProjectileID.Starfury;
                            break;
                        case int swart
                        when swart == 2:
                            Item.shoot = ProjectileID.StarCannonStar;
                            break;
                        default:
                            Item.shoot = 0;
                            Item.damage = 200;
                            break;
                    }
                }
            }
            else
            {
                Item.useStyle = ItemUseStyleID.Swing;
                Item.shootSpeed = 10f;
                Item.shoot = 0;
                Item.damage = 200;
            }
            player.GetModPlayer<Jugador>().checkCrest();
        }

        public override bool? UseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                if (player.GetModPlayer<Jugador>().Charon)
                {
                    useCount += 2;
                }
                else
                {
                    switch (player.GetModPlayer<Jugador>().SwordArt)
                    {
                        case int swart
                        when swart == 1:
                            useCount += 2;
                            break;
                        case int swart
                        when swart == 2:
                            useCount += 3;
                            break;
                        default:
                            break;
                    }
                }
            }

            if (player.whoAmI != Main.myPlayer)
            {
                return true;
            }

            return true;
        }

        public override bool ConsumeItem(Player player)
        {
            useCount++;
            if (useCount >= MaxUses)
            {
                useCount = 0;
                return true;
            }

            return false;
        }

        public override void SaveData(TagCompound tag)
        {
            tag["useCount"] = useCount;
        }

        public override void LoadData(TagCompound tag)
        {
            useCount = tag.Get<int>("useCount");
        }

        public override void NetSend(BinaryWriter writer)
        {
            writer.Write(useCount);
        }

        public override void NetReceive(BinaryReader reader)
        {
            useCount = reader.ReadInt32();
        }

        public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            if (useCount == 0)
            {
                return;
            }

            Vector2 spriteSize = frame.Size() * scale;

            spriteBatch.Draw(TextureAssets.MagicPixel.Value,
                position: new Vector2(position.X, position.Y + spriteSize.Y * 0.9f),
                sourceRectangle: new Rectangle(0, 0, 1, 1),
                Color.Red,
                rotation: 0f,
                origin: Vector2.Zero,
                scale: new Vector2(spriteSize.X * (MaxUses - useCount) / MaxUses, 2f),
                SpriteEffects.None,
                layerDepth: 0f);
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
