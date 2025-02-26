using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using FireEmblem3H.Content.Projectiles;

namespace FireEmblem3H.Content.Items.Tools
{
    public class SwordOfCreation : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; // Amount of this item needed to research and become available in Journey mode's duplication menu. Amount based on vanilla hooks' amount needed
        }

        public override void SetDefaults()
        {
            // Copy values from the Amethyst Hook
            Item.CloneDefaults(ItemID.AmethystHook);
            Item.shootSpeed = 22f; // This defines how quickly the hook is shot.
            Item.shoot = ModContent.ProjectileType<HookOfCreation>(); // Makes the item shoot the hook's projectile when used.
        }

        public override void UseAnimation(Player player)
        {
            player.GetModPlayer<Jugador>().checkCrest();
        }

    }
}
