using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Creates and initializes a new Queue.
            var queue = new Queue<Artist>();

            queue.Enqueue(new Artist
            {
                GenreId = "Neue Deutsche Härte",
                Name = "Rammstein",
                RecordId = 1
            });
            queue.Enqueue(new Artist
            {
                GenreId = "Neue Deutsche Härte",
                Name = "OOMPH!",
                RecordId = 2
            });
            queue.Enqueue(new Artist
            {
                GenreId = "Neue Deutsche Härte",
                Name = "Eisbrecher",
                RecordId = 3
            });

            foreach (var artist in queue)
            {
                Console.WriteLine($"Name: {artist.Name}, Genre: {artist.GenreId}");
            }

            //queue.Peek();
            //queue.Dequeue();

            var artistArray = new Artist[4];

            artistArray[0] = new Artist
            {
                Name = "Hayley kioko",
                GenreId = "Pop",
                RecordId = 4
            };

            artistArray[1] = new Artist
            {
                Name = "Glass animals",
                GenreId = "Vaporwave idk",
                RecordId = 5
            };

            foreach (var artist in artistArray)
            {
                if (artist == default) continue;
                Console.WriteLine(artist.Name);
            }

            var artistList = new List<Artist>();
            artistList.AddRange(artistArray);
            

            artistList.Add(new Artist
            {
                Name = "Halestorm",
                GenreId = "Rock",
                RecordId = 6
            });

            artistList.ForEach(x => Console.WriteLine(x?.Name));



        }


    }
}

