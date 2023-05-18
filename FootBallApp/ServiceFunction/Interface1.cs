using FinalAssignment.Model;
using System;


namespace FinalAssignment.ServiceFunction
{
    internal class Interface1
    {
       public  int CreateStudent(Player player);
        List<Player> GetList();
       public  void Update(int id);
        public void Delete(int id);
        public void search(int id);
    }
}
