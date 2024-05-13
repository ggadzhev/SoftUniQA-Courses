namespace _03._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<StoreBox> boxes = new List<StoreBox>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] storeBoxParams = input.Split();
                string boxSerialNumber = storeBoxParams[0];
                string itemName = storeBoxParams[1];
                int itemQuantity = int.Parse(storeBoxParams[2]);
                double itemValue = double.Parse(storeBoxParams[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Value = itemValue
                };

                StoreBox storeBox = new StoreBox()
                {
                    SerialNumber = boxSerialNumber,
                    ItemObject = item,
                    ItemQuantity = itemQuantity,
                    BoxPrice = itemValue * itemQuantity,
                };


                input = Console.ReadLine();

            }

            List<StoreBox> orderedBoxes = boxes.OrderByDescending(b => b.BoxPrice).ToList();

            foreach (var box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemObject.Name} - ${box.ItemObject.Value:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }

        }
    }




    class Item
    {
        public string Name { get; set; }
        public double Value { get; set; }

    }
    class StoreBox
    {
        public string SerialNumber { get; set; }
        public Item ItemObject { get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice { get; set; }


    }
}
