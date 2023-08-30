using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private int level;
        private string username;

        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
            this.level = level;
            this.username = username;   
        }

        public string Username { get; set; }
        public int Level { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format($"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}"));
            return sb.ToString();
        }
    }
}
