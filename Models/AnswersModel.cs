using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1.Models
{
    public class AnswersModel
    {
        public bool dog1 { get; set; }
        public bool cat1 { get; set;  }

        public Dictionary<string, List<object>> iscat { get; set; } = 
           new Dictionary<string, List<object>>()
            {
               {"dog", [false, "Images/thedog.webp"]},
               {"cat", [true, "Images/catlick.webp"]},
               {"birma", [true, "Images/birma.webp"] },
               {"cutecat", [true, "Images/cutecat.webp"] },
               {"dogdog", [false, "Images/dogdog.webp"] },
               {"evilcat", [true, "Images/evilcat.webp"] },
               {"pomeranian", [false, "Images/pomeranianflying.png"] },
               {"TheDog", [false, "Images/thedog.webp"] },  
               {"thinker", [true, "Images/thethinker.png"] },
               {"bee", [false, "Images/bee.webp"] },
               {"catbun", [true, "Images/cat bunny.webp"] },

            };
        public string[] selected { get; set; } = [];


    }
}
