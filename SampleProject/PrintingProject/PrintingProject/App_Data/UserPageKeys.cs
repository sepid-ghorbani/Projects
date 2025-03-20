using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class UserPageKeys
	{

		#region Data Members

		int _user_Id;
		int _page_Id;

		#endregion

		#region Constructor

		public UserPageKeys(int user_Id, int page_Id)
		{
			 _user_Id = user_Id; 
			 _page_Id = page_Id; 
		}

		#endregion

		#region Properties

		public int  User_Id
		{
			 get { return _user_Id; }
		}
		public int  Page_Id
		{
			 get { return _page_Id; }
		}

		#endregion

	}
}
