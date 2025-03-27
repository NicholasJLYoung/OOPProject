namespace LMSBL
{
    public abstract class User
    {
        public string Name { get; set; }
        public int UserID { get; set; }
        public string Role { get; set; }
        public abstract void DisplayRole();
    }
}
