﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenWallet.Daemon.Models
{
    public class SuccessResponse : BaseResponse
    {
		public SuccessResponse() => Success = true;
	}
}
