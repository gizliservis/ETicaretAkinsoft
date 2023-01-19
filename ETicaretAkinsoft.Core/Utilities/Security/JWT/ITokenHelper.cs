﻿using ETicaretAkinsoft.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaretAkinsoft.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}

//23.05 Dersteyiz