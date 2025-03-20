using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Messages: BusinessObjectBase
	{

		#region InnerClass
		public enum MessagesFields
		{
			Id,
			Title,
			Body,
			Date,
			SenderId,
			ReceiverId,
			SenderDeleted,
			ReceiverDeleted,
			Read
		}
		#endregion

		#region Data Members

			int _id;
			string _title;
			string _body;
			DateTime _date;
			int _senderId;
			int _receiverId;
			bool _senderDeleted;
			bool _receiverDeleted;
			bool _read;

		#endregion

		#region Properties

		public int  Id
		{
			 get { return _id; }
			 set
			 {
				 if (_id != value)
				 {
					_id = value;
					 PropertyHasChanged("Id");
				 }
			 }
		}

		public string  Title
		{
			 get { return _title; }
			 set
			 {
				 if (_title != value)
				 {
					_title = value;
					 PropertyHasChanged("Title");
				 }
			 }
		}

		public string  Body
		{
			 get { return _body; }
			 set
			 {
				 if (_body != value)
				 {
					_body = value;
					 PropertyHasChanged("Body");
				 }
			 }
		}

		public DateTime  Date
		{
			 get { return _date; }
			 set
			 {
				 if (_date != value)
				 {
					_date = value;
					 PropertyHasChanged("Date");
				 }
			 }
		}

		public int  SenderId
		{
			 get { return _senderId; }
			 set
			 {
				 if (_senderId != value)
				 {
					_senderId = value;
					 PropertyHasChanged("SenderId");
				 }
			 }
		}

		public int  ReceiverId
		{
			 get { return _receiverId; }
			 set
			 {
				 if (_receiverId != value)
				 {
					_receiverId = value;
					 PropertyHasChanged("ReceiverId");
				 }
			 }
		}

		public bool  SenderDeleted
		{
			 get { return _senderDeleted; }
			 set
			 {
				 if (_senderDeleted != value)
				 {
					_senderDeleted = value;
					 PropertyHasChanged("SenderDeleted");
				 }
			 }
		}

		public bool  ReceiverDeleted
		{
			 get { return _receiverDeleted; }
			 set
			 {
				 if (_receiverDeleted != value)
				 {
					_receiverDeleted = value;
					 PropertyHasChanged("ReceiverDeleted");
				 }
			 }
		}

		public bool  Read
		{
			 get { return _read; }
			 set
			 {
				 if (_read != value)
				 {
					_read = value;
					 PropertyHasChanged("Read");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Title", "Title"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Title", "Title",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Body", "Body"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Body", "Body",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Date", "Date"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("SenderId", "SenderId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ReceiverId", "ReceiverId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("SenderDeleted", "SenderDeleted"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ReceiverDeleted", "ReceiverDeleted"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Read", "Read"));
		}

		#endregion

	}
}
