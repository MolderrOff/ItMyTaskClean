using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItMyTaskClean.Application.DTOs.Request;

public record WorkParamsRequest(string NameTask, int TaskNumber, string Description, string Customer, string AdressTask, decimal Price);
