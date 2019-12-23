using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavyPQS
{
    class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        public int score { get; set; }
        public int lastScore { get; set; }
        public int lastscoreMultiplyer { get; set; }
        public int currentScoreMultiplyer { get; set; }
        public bool isAdmin; 
    }
}
