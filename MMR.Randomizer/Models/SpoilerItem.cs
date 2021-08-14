﻿using MMR.Randomizer.Extensions;
using MMR.Randomizer.GameObjects;

namespace MMR.Randomizer.Models
{
    public class SpoilerItem
    {
        public int Id { get; }
        public string Name { get; }

        public int NewLocationId { get; }
        public string NewLocationName { get; }

        public Region Region { get; }

        public bool IsJunk { get; }

        public bool IsImportant { get; }

        public bool IsRequired { get; }

        public bool IsImportantSong { get; }

        public SpoilerItem(ItemObject itemObject, Region region, bool isRequired, bool isImportant, bool isImportantSong, bool progressiveUpgrades)
        {
            Id = itemObject.ID;
            Name = itemObject.NameOverride ?? itemObject.Item.ProgressiveUpgradeName(progressiveUpgrades) ?? itemObject.Name;
            NewLocationId = (int)itemObject.NewLocation.Value;
            NewLocationName = itemObject.NewLocation.Value.Location();
            Region = region;
            IsJunk = Name.Contains("Rupee") || Name.Contains("Heart") || itemObject.Item == Item.IceTrap;
            IsImportant = isImportant;
            IsRequired = isRequired;
            IsImportantSong = isImportantSong;
        }
    }
}
