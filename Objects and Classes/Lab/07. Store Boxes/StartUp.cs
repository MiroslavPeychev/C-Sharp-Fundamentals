namespace _07._Store_Boxes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                string[] tokens = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int quantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Item item = new Item
                {
                    Name = itemName,
                    Price = itemPrice
                };

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = quantity,
                    PriceForABox = item.Price * quantity
                };

                boxes.Add(box);

            }

            var orderedBoxes = boxes.OrderByDescending(p => p.PriceForABox);

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"--${box.PriceForABox:F2}");
            }
        }

        public class Item
        {
            public string Name { get; set; }

            public decimal Price { get; set; }
        }

        
        public class Box
        {
            public Box()
            {
                Item = new Item();
            }

            public string SerialNumber { get; set; }

            public Item Item { get; set; }

            public int ItemQuantity { get; set; }

            public decimal PriceForABox { get; set; }
        }
    }
}