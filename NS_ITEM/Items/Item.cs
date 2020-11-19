using NS_ITEMS.Items.Currencies;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS_ITEMS.Items
{

    public class Item : Entity
    {
        protected RarityType Rarity;
        protected Currency Currency;
        protected ushort CurrentStack, MaximumStack;
    }
}
