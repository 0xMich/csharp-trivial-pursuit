using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivial_Pursuit.Model
{
    class Player
    {
        public int Id { get; private set; }
        public int Score { get; set; }
        public string Name { get; private set; }
        public int Position { get; set; }

        public Player(int id, string name, int score, int position)
        {
            this.Name = name;
            this.Id = id;
            this.Score = score;
            this.Position = position;
        }
    }
}
