using System.Collections.Generic;
using Commander2.Models;

namespace Commander2.Data {
    public interface ICommanderRepo {

        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int id);
    }
}