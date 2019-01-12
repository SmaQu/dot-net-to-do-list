﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Data.Entities;

namespace TaskManager.Data.QueryProcessors
{
	public interface IUserByIdQueryProcessor
	{
		User GetUserById(long userId);
	}
}
