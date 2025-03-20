using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class UsePaper: BusinessObjectBase
	{

		#region InnerClass
		public enum UsePaperFields
		{
			Id,
			JobId,
			FromInstituteId,
			MaterialTypeId,
			MaterialTypeGramazhId,
			PaperWidthId,
			PaperHeightId,
			LeafCount,
            Description
		}
		#endregion

		#region Data Members

			int _id;
			int _jobId;
			int _fromInstituteId;
			int _materialTypeId;
			int _materialTypeGramazhId;
			int _paperWidthId;
			int _paperHeightId;
			int _leafCount;
            string _description;

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

		public int  FromInstituteId
		{
			 get { return _fromInstituteId; }
			 set
			 {
				 if (_fromInstituteId != value)
				 {
					_fromInstituteId = value;
					 PropertyHasChanged("FromInstituteId");
				 }
			 }
		}

		public int  MaterialTypeId
		{
			 get { return _materialTypeId; }
			 set
			 {
				 if (_materialTypeId != value)
				 {
					_materialTypeId = value;
					 PropertyHasChanged("MaterialTypeId");
				 }
			 }
		}

		public int  MaterialTypeGramazhId
		{
			 get { return _materialTypeGramazhId; }
			 set
			 {
				 if (_materialTypeGramazhId != value)
				 {
					_materialTypeGramazhId = value;
					 PropertyHasChanged("MaterialTypeGramazhId");
				 }
			 }
		}

		public int  PaperWidthId
		{
			 get { return _paperWidthId; }
			 set
			 {
				 if (_paperWidthId != value)
				 {
					_paperWidthId = value;
					 PropertyHasChanged("PaperWidthId");
				 }
			 }
		}

		public int  PaperHeightId
		{
			 get { return _paperHeightId; }
			 set
			 {
				 if (_paperHeightId != value)
				 {
					_paperHeightId = value;
					 PropertyHasChanged("PaperHeightId");
				 }
			 }
		}

		public int  LeafCount
		{
			 get { return _leafCount; }
			 set
			 {
				 if (_leafCount != value)
				 {
					_leafCount = value;
					 PropertyHasChanged("LeafCount");
				 }
			 }
		}
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    PropertyHasChanged("Description");
                }
            }
        }


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobId", "JobId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FromInstituteId", "FromInstituteId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MaterialTypeId", "MaterialTypeId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MaterialTypeGramazhId", "MaterialTypeGramazhId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PaperWidthId", "PaperWidthId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PaperHeightId", "PaperHeightId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("LeafCount", "LeafCount"));
		}

		#endregion

	}
}
