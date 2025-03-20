using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class JobStatusesKeys
	{

		#region Data Members

		int _jobId;
		int _statusId;

		#endregion

		#region Constructor

		public JobStatusesKeys(int jobId, int statusId)
		{
			 _jobId = jobId; 
			 _statusId = statusId; 
		}

		#endregion

		#region Properties

		public int  JobId
		{
			 get { return _jobId; }
		}
		public int  StatusId
		{
			 get { return _statusId; }
		}

		#endregion

	}
}
