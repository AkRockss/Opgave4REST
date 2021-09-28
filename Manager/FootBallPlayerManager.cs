using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Opgave4REST.Models;

namespace Opgave4REST.Manager
{
    public class FootBallPlayerManager
    {
        private static int _nextId = 1;

        //Static List 

        private static readonly List<FootBallPlayer> Data = new List<FootBallPlayer>
        {
            new FootBallPlayer {Id = _nextId++, Name = "Ronaldinho", Price = 1110000, ShirtNumber = 01},
            new FootBallPlayer {Id = _nextId++, Name = "Messi", Price = 2110000, ShirtNumber = 02}

        };

        //Copy Ctor
        public List<FootBallPlayer> GetAll()
        {
            return new List<FootBallPlayer>(Data);
        }

        //Create
        public FootBallPlayer Add(FootBallPlayer newFootBallPlayer)
        {
            newFootBallPlayer.Id = _nextId++;
            Data.Add(newFootBallPlayer);
            return newFootBallPlayer;
        }

        //Read
        public FootBallPlayer GetById(int id)
        {
            return Data.Find(FootBallPlayer => FootBallPlayer.Id == id);
        }

        //Update
        public FootBallPlayer Update(int id, FootBallPlayer updates)
        {
            FootBallPlayer footBallPlayer = Data.Find(footBallPlayer1 => footBallPlayer1.Id == id);
            if (footBallPlayer == null) return null;
            footBallPlayer.Name = updates.Name;
            footBallPlayer.Price = updates.Price;
            footBallPlayer.ShirtNumber = updates.ShirtNumber;
            return footBallPlayer;
        }

        //Delete
        public FootBallPlayer Delete(int id)
        {
            FootBallPlayer footBallPlayer = Data.Find(footBallPlayer1 => footBallPlayer1.Id == id);
            if (footBallPlayer == null) return null;
            Data.Remove(footBallPlayer);
            return footBallPlayer;
        }






    }
}
