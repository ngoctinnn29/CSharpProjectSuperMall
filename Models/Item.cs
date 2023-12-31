﻿using System;


namespace Models
{   /// <summary>
/// LỚP MÔ TẢ THÔNG TIN MẶT HÀNG   
/// </summary>
    public class Item : IComparable<Item>
    {
        private static int s_autoId = 1000000;
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int Quanlity { get; set; }
        public string Brand { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Price { get; set; }
        public Discount Discount { get; set; }

        public Item() { }
        public Item(int id)
        {
            ItemId = id > 0 ? id : s_autoId++;
        }
        public Item(int itemId, string itemName, string itemType, 
            int quatity, string brand, DateTime releaseDate,
            int price, Discount discount) : this(itemId)
        {
          ItemName = itemName;
            ItemType = itemType;
            Quanlity = quatity;
            Brand = brand;
            ReleaseDate = releaseDate;
            Price = price;
            Discount = discount;
        }

        public static void UpdateAutoId(int v)
        {
            s_autoId = v;
        }


        public int CompareTo(Item other)
        {
            return ItemId - other.ItemId;
        }

        public override bool Equals(object obj)
        {
            return obj is Item item &&
                   ItemId == item.ItemId;
        }

        public override int GetHashCode()
        {
            return -2113648141 + ItemId.GetHashCode();
        }
    }
}
