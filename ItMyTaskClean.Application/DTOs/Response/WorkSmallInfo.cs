using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItMyTaskClean.Application.DTOs.Response;

public record WorkSmallInfo(Guid id, string nameTask, int taskNumber, string description, string customer, string adressTask, decimal price);
