﻿using System;

namespace LogFlow.Specifications.Helpers
{
	public class EmptyInput : LogInput
	{
		public static bool IsFinished;

		public override Result GetLine()
		{
			return new Result(LogContext);
		}

		public override void LineIsProcessed(Result result)
		{
			IsFinished = true;
		}
	}
}
