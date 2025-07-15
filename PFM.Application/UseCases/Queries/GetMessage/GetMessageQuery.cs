using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace PFM.Application.UseCases.Queries.GetMessage
{
    public record GetMessageQuery() : IRequest<string>;
}
