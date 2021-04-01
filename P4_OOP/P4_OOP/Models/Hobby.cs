namespace P4_OOP.Models
{
    public class Hobby
    {
        public Hobby()
        {
        }

        public Hobby(int hobbyId, string text, string textLt)
        {
            HobbyId = hobbyId;
            Text = text;
            TextLt = textLt;
        }

        public int HobbyId { get; set; }
        public string Text { get; set; }
        public string TextLt { get; set; }
    }
}
