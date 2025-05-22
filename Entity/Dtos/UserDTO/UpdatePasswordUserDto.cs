using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.Base;

namespace Entity.Dtos.UserDTO
{
    /// <summary>
    /// DTO para actualizar la contraseña del usuario (operación UPDATE parcial)
    /// </summary>
    public class UpdatePasswordUserDto : BaseDto
    {
        public required string Password { get; set; }
    }
}
