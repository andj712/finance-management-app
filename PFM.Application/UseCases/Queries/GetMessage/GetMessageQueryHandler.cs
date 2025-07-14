using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace PFM.Application.UseCases.Queries.GetMessage
{
    public class GetMessageQueryHandler : IRequestHandler<GetMessageQuery, string>
    {
        public Task<string> Handle(GetMessageQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Hello!");
        }
    }
}
