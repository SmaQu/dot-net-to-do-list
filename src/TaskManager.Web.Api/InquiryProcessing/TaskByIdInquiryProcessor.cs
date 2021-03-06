﻿using TaskManager.Common.TypeMapping;
using TaskManager.Data.Exceptions;
using TaskManager.Data.QueryProcessors;
using TaskManager.Web.Api.Models;

namespace TaskManager.Web.Api.InquiryProcessing
{
	public class TaskByIdInquiryProcessor : ITaskByIdInquiryProcessor
	{
		private readonly IAutoMapper _autoMapper;
		private readonly ITaskByIdQueryProcessor _queryProcessor;

		public TaskByIdInquiryProcessor(ITaskByIdQueryProcessor queryProcessor, IAutoMapper autoMapper)
		{
			_queryProcessor = queryProcessor;
			_autoMapper = autoMapper;
		}
		public Task GetTaskById(long taskId)
		{
			var taskEntity = _queryProcessor.GetTaskById(taskId);

			if (taskEntity == null)
			{
				throw new RootObjectNotFoundException("Task not found");
			}

			var task = _autoMapper.Map<Task>(taskEntity);
			return task;
		}
	}
}