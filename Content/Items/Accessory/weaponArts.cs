using FireEmblem3H.Content.Items.Materials;
using FireEmblem3H.Content.Tiles;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FireEmblem3H.Content.Items.Accessory
{
    public abstract class weaponArt : ModItem
    {
        public enum skillsArts
        {
            sword,
            lance,
            axe,
            bow,
            fist,
        }

        public override void SetDefaults()
        {
            Item.width = 25;
            Item.height = 25;

            Item.rare = ItemRarityID.Purple;
            Item.value = 5000000;

            Item.accessory = true;
        }
    }

    public abstract class swordArt : weaponArt
    {
        public enum swordSkillArts
        {
            wrathStrike,
            grounder,
            astra,
            assasinate,
            soulblade,
        }

        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            if (slot == ((int)skillsArts.sword))
            {
                return true;
            }
            return false;
        }
    }

    public abstract class lanceArt : weaponArt
    {
        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            if (slot == ((int)skillsArts.lance))
            {
                return true;
            }
            return false;
        }
    }

    public abstract class axeArt : weaponArt
    {
        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            if (slot == ((int)skillsArts.axe))
            {
                return true;
            }
            return false;
        }
    }

    public abstract class bowArt : weaponArt
    {
        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            if (slot == ((int)skillsArts.bow))
            {
                return true;
            }
            return false;
        }
    }

    public abstract class fistArt : weaponArt
    {
        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            if (slot == ((int)skillsArts.fist))
            {
                return true;
            }
            return false;
        }
    }

    public class wrathStrike : swordArt
    {
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<Jugador>().SwordArt = swordSkillArts.wrathStrike.ToString();
        }
    }

    public class grounder : swordArt
    {
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<Jugador>().SwordArt = swordSkillArts.grounder.ToString();
        }
    }

    public class astra : swordArt
    {
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<Jugador>().SwordArt = swordSkillArts.astra.ToString();
        }
    }

    public class assasinate : swordArt
    {
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<Jugador>().SwordArt = swordSkillArts.assasinate.ToString();
        }
    }

    public class soulblade : swordArt
    {
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<Jugador>().SwordArt = swordSkillArts.soulblade.ToString();
        }
    }
}
