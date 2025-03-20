using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class JobStatuses: BusinessObjectBase
	{

		#region InnerClass
		public enum JobStatusesFields
		{
			JobId,
			StatusId
		}
		#endregion

		#region Data Members

			int _jobId;
			int _statusId;

		#endregion

		#region Properties

		public int  JobId
		{
			 get { return _jobId; }
			 set
			 {
				 if (_jobId != value)
				 {
					_jobId = value;
					 PropertyHasChanged("JobId");
				 }
			 }
		}

		public int  StatusId
		{
			 get { return _statusId; }
			 set
			 {
				 if (_statusId != value)
				 {
					_statusId = value;
					 PropertyHasChanged("StatusId");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobId", "JobId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("StatusId", "StatusId"));
		}

		#endregion

	}
}
