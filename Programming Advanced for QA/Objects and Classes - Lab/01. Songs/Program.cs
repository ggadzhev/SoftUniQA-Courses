namespace _01._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Songs> songsList = new List<Songs>();

            int numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] inputParams = Console.ReadLine().Split("_");

                string songListType = inputParams[0];
                string songName = inputParams[1];
                string songTime = inputParams[2];

                Songs currentSong = new Songs();
                currentSong.Name = songName;
                currentSong.TypeOfList = songListType;
                currentSong.Time = songTime;


                songsList.Add(currentSong);
            }

            string currentList = Console.ReadLine();

            if (currentList == "all")
            {
                foreach (Songs songs in songsList)
                {
                    Console.WriteLine(songs.Name);
                }

            }
            else
            {
                List<Songs> filteredSongs = songsList.Where(s => s.TypeOfList == currentList).ToList();

                foreach (Songs songs in filteredSongs)
                {
                    Console.WriteLine(songs.Name);
                }
            }

            
        }
    }

    class Songs
    {
        public string TypeOfList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
