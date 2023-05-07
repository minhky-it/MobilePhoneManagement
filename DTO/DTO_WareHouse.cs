
namespace DTO
{
    public class DTO_WareHouse
    {
        private string ID;
        private string dateInput;

        public DTO_WareHouse(string iD, string dateInput)
        {
            this.ID = iD;
            this.dateInput = dateInput;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string DateInput { get => dateInput; set => dateInput = value; }
    }
}
