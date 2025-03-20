using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class StereotypeUsagesKeys
	{

		#region Data Members

		int _id;

		#endregion

		#region Constructor

		public StereotypeUsagesKeys(int id)
		{
			 _id = id; 
		}

		#endregion

		#region Properties

		public int  Id
		{
			 get { return _id; }
		}

		#endregion

	}
}
