using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Contracts;

public interface INotifficationHandler
{
    public void NotiffyUser(Guid userId, string messgae);
}
