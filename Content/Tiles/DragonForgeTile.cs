using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace FireEmblem3H.Content.Tiles
{
    public class DragonForgeTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            // Properties
            Main.tileTable[Type] = true;
            Main.tileSolidTop[Type] = false;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;

            AdjTiles = new int[] { TileID.Anvils, TileID.MythrilAnvil, TileID.Furnaces, TileID.Hellforge, TileID.AdamantiteForge };

            // Placement
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.CoordinateHeights = new[] { 18,14 };
            TileObjectData.addTile(Type);

            // Etc
            //ModTranslation name = CreateMapEntryName();
            //name.SetDefault("Dragon Forge");
            //AddMapEntry(new Color(245,94,94), name);
        }
    }
}