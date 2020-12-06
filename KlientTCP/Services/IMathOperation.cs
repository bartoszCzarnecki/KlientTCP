using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientTCP.Services
{
    public interface IMathOperation
    {
        string TriangleType(string values, IServerCommunication communication);
    }
}
