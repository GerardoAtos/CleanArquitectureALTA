using Alta.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface ILoginInputPort
    {
        Task Handle(UserDTO user);
    }
}
