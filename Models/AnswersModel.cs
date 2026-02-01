namespace WebApplication1.Models
{
    public class AnswersModel
    {
        public bool dog1 { get; set; }
        public bool cat1 { get; set;  }

        public Dictionary<string, List<object>> iscat { get; set; } = 
           new Dictionary<string, List<object>>()
            {
                {"dog1", [false, "Images/thedog.webp"]},
                {"cat1", [true, "Images/catlick.webp"]},
               {"cattank", [true, "Images/304_3.webp"]}
            };
        public string[] selected { get; set; } = [];


    }
}
