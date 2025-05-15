using ProjectStructureDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructureDemo.Services
{
    // <summary>
    // Сервис для работы с пользователями
    // </summary>
    public class UserService
    {
        private readonly List<User> _users = new();

        // <summary>
        // Добавляет нового пользователя
        // </summary>
        // <param name="user">Объект пользователя</param>
        public void AddUser(User user)
        {
            _users.Add(user);
        }

        // <summary>
        // Получает пользователя по идентификатору
        // </summary>
        // <param name="id">Идентификатор пользователя</param>
        // <returns>Найденный пользователь или null</returns>
        public User? GetUser(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }
    }
}
