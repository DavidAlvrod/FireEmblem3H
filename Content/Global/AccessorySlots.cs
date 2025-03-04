using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using FireEmblem3H.Content.Global;
using FireEmblem3H.Content.Items.Accessory;

namespace FireEmblem3H.Content.Global
{
    public class A_SwordArtSlot : ModAccessorySlot
    {
        public override bool CanAcceptItem(Item item, AccessorySlotType context)
        {
            switch (item.type)
            {
                case int id
                when id == ModContent.ItemType<wrathStrike>()
                || id == ModContent.ItemType<grounder>():
                    return true;
                default:
                    return false;
            }
        }

        public override bool DrawVanitySlot => false;
        public override bool DrawDyeSlot => false;
        public override string FunctionalTexture => "Terraria/Images/Item_" + ItemID.FieryGreatsword;
        public override string FunctionalBackgroundTexture => "Terraria/Images/Inventory_Back2";

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch(context)
            {
                case AccessorySlotType.FunctionalSlot:
                    Main.hoverItemName = "Sword Art";
                        break;
            }
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            switch (item.type)
            {
                case int id
                when id == ModContent.ItemType<wrathStrike>()
                || id == ModContent.ItemType<grounder>():
                    return true;
                default:
                    return false;
            }
        }
    }

    public class B_LanceArtSlot : ModAccessorySlot
    {
        public override bool CanAcceptItem(Item item, AccessorySlotType context)
        {
            //if (item.type == ModContent.ItemType<aaaa>())
            //{
            //    return true;
            //}
            return false;
        }

        public override bool DrawVanitySlot => false;
        public override bool DrawDyeSlot => false;
        public override string FunctionalTexture => "Terraria/Images/Item_" + ItemID.Gungnir;
        public override string FunctionalBackgroundTexture => "Terraria/Images/Inventory_Back4";

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
                case AccessorySlotType.FunctionalSlot:
                    Main.hoverItemName = "Lance Art";
                    break;
            }
        }
    }

    public class C_AxeArtSlot : ModAccessorySlot
    {
        public override bool CanAcceptItem(Item item, AccessorySlotType context)
        {
            //if (item.type == ModContent.ItemType<aaaa>())
            //{
            //    return true;
            //}
            return false;
        }

        public override bool DrawVanitySlot => false;
        public override bool DrawDyeSlot => false;
        public override string FunctionalTexture => "Terraria/Images/Item_" + ItemID.LunarHamaxeVortex;
        public override string FunctionalBackgroundTexture => "Terraria/Images/Inventory_Back3";

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
                case AccessorySlotType.FunctionalSlot:
                    Main.hoverItemName = "Axe Art";
                    break;
            }
        }
    }

    public class D_BowArtSlot : ModAccessorySlot
    {
        public override bool CanAcceptItem(Item item, AccessorySlotType context)
        {
            //if (item.type == ModContent.ItemType<aaaa>())
            //{
            //    return true;
            //}
            return false;
        }

        public override bool DrawVanitySlot => false;
        public override bool DrawDyeSlot => false;
        public override string FunctionalTexture => "Terraria/Images/Item_" + ItemID.FairyQueenRangedItem;
        public override string FunctionalBackgroundTexture => "Terraria/Images/Inventory_Back14";

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
                case AccessorySlotType.FunctionalSlot:
                    Main.hoverItemName = "Bow Art";
                    break;
            }
        }
    }

    public class E_FistArt : ModAccessorySlot
    {
        public override bool CanAcceptItem(Item item, AccessorySlotType context)
        {
            //if (item.type == ModContent.ItemType<aaaa>())
            //{
            //    return true;
            //}
            return false;
        }

        public override bool DrawVanitySlot => false;
        public override bool DrawDyeSlot => false;
        public override string FunctionalTexture => "Terraria/Images/Item_" + ItemID.HandOfCreation;
        public override string FunctionalBackgroundTexture => "Terraria/Images/Inventory_Back5";

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
                case AccessorySlotType.FunctionalSlot:
                    Main.hoverItemName = "Fist Art";
                    break;
            }
        }
    }
}
