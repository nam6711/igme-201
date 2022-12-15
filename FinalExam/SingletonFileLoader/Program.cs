using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SingletonFileLoader
{
    // Struct : SEntitiy
    // Author : Nat Manoucheri
    // Purpose : Holds generic entity info, so if needed to
    //      be loaded, it can use this as a general outline be
    //      it a player or enemy or opposing player, etc.
    public struct SEntity
    {
        public string player_name;
        public int level;
        public int hp;
        public string[] inventory;
        public string license_key;
    }

    // Class Player
    // Author : Nat Manoucheri
    // Purpose : Holds player data and info.
    //           Contains methods to load and save player data via JSON
    // Restrictions : Singleton class, that is created on program start
    public class Player
    {
        // player items
        public string player_name;
        public int level;
        public int hp;
        public string[] inventory;
        private string license_key;

        // Constructor Player
        // Author : Nat Manoucheri
        // Purpose : Load a player via the given source string
        // Restrictions : Private, meaning only used for singleton classes
        private Player (string src)
        {
            // read JSON file using the given player data
            StreamReader r = new StreamReader(src);
            string s = r.ReadToEnd();
            r.Close();

            // load JSON data, then set to a new Player instance
            // create a generic entity using the data
            SEntity entities = JsonConvert.DeserializeObject<SEntity>(s);
            // load the struct data into the player's unique data
            this.player_name = entities.player_name;
            this.level = entities.level;
            this.hp = entities.hp;
            this.inventory = entities.inventory;
            this.license_key = entities.license_key;
        }

        // creates the singleton player
        private static Player player = new Player("player.json");


        // Method : GetPlayer
        // Author : Nat Manoucheri
        // Purpose : Returns the singleton player
        // Returns : Player player - the singleton instance of the player created
        //              on program start
        public static Player GetPlayer()
        {
            return player;
        }

        // Method : Save
        // Author : Nat Manoucheri
        // Purpose : Saves the player's data to memory
        public void Save()
        {
            // serialize the player data
            string s = JsonConvert.SerializeObject(player);

            // save to the JSON file
            StreamWriter w = new StreamWriter("player.json");
            w.Write(s);
            w.Close();
            Console.WriteLine("****** PLAYER DATA SAVED ******");
        }

        // Method : Load
        // Author : Nat Manoucheri
        // Purpose : Loads the player's data from memory
        public void Load()
        {
            // read JSON file using the given player data
            StreamReader r = new StreamReader("player.json");
            string s = r.ReadToEnd();
            r.Close();

            // load JSON data, then set to a new Player instance
            // create a generic entity using the data
            SEntity entities = JsonConvert.DeserializeObject<SEntity>(s);
            // load the struct data into the player's unique data
            this.player_name = entities.player_name;
            this.level = entities.level;
            this.hp = entities.hp;
            this.inventory = entities.inventory;
            this.license_key = entities.license_key;
            Console.WriteLine("****** PLAYER DATA LOADED ******");
            Console.WriteLine(player.ToString());
        }

        // Method : ToString
        // Author : Nat Manoucheri
        // Purpose : Converts the contents to a readable string
        public override string ToString()
        {
            string s = "NAME : " + this.player_name.ToString() + "\n";
            s += "LEVEL : " + this.level + "\n";
            s += "HP : " + this.hp + "\n";
            s += "INVENTORY : " + this.inventory.ToString() + "\n";
                s += "LICENSE KEY : " + this.license_key;

            return s;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // tests load method
            Player player = Player.GetPlayer();
            Console.WriteLine("Load Method");
            player.Load();

            // change some aspect then save the file
            Console.WriteLine("Save Method after changing the player name");
            player.player_name = "nat manoucheri";
            player.Save();
        }
    }
}
