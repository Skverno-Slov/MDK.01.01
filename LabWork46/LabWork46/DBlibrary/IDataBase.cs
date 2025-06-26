namespace DBlibrary
{
    public interface IDataBase
    {
        public int ExecuteQuery(string command);

        public bool UpdateGame(int id, string title, decimal price);

        public void InsertGame(string title, decimal price, int date);
    }
}
