using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class FinalInvoice: BusinessObjectBase
	{


        #region InnerClass
        public enum FinalInvoiceFields
        {
            Id,
            HasInvoice,
            JobId,
            PlateCost,
            FilmCost,
            CopyZinkCost,
            StereotypeCost,
            PrintingCost,
            BuyPaperCost,
            VeneerCost,
            LetterPressCost,
            MakingTemplateCost,
            SahafiCost,
            SumAll,
            Description
        }
        #endregion

        #region Data Members

        int _id;
        bool _hasInvoice;
        int _jobId;
        decimal _plateCost;
        decimal _filmCost;
        decimal _copyZinkCost;
        decimal _stereotypeCost;
        decimal _printingCost;
        decimal _buyPaperCost;
        decimal _veneerCost;
        decimal _letterPressCost;
        decimal _makingTemplateCost;
        decimal _sahafiCost;
        decimal _sumAll;
        string _description;

        #endregion

        #region Properties

        public int Id
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

        public bool HasInvoice
        {
            get { return _hasInvoice; }
            set
            {
                if (_hasInvoice != value)
                {
                    _hasInvoice = value;
                    PropertyHasChanged("HasInvoice");
                }
            }
        }

        public int JobId
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

        public decimal PlateCost
        {
            get { return _plateCost; }
            set
            {
                if (_plateCost != value)
                {
                    _plateCost = value;
                    PropertyHasChanged("PlateCost");
                }
            }
        }

        public decimal FilmCost
        {
            get { return _filmCost; }
            set
            {
                if (_filmCost != value)
                {
                    _filmCost = value;
                    PropertyHasChanged("FilmCost");
                }
            }
        }

        public decimal CopyZinkCost
        {
            get { return _copyZinkCost; }
            set
            {
                if (_copyZinkCost != value)
                {
                    _copyZinkCost = value;
                    PropertyHasChanged("CopyZinkCost");
                }
            }
        }

        public decimal StereotypeCost
        {
            get { return _stereotypeCost; }
            set
            {
                if (_stereotypeCost != value)
                {
                    _stereotypeCost = value;
                    PropertyHasChanged("StereotypeCost");
                }
            }
        }

        public decimal PrintingCost
        {
            get { return _printingCost; }
            set
            {
                if (_printingCost != value)
                {
                    _printingCost = value;
                    PropertyHasChanged("PrintingCost");
                }
            }
        }

        public decimal BuyPaperCost
        {
            get { return _buyPaperCost; }
            set
            {
                if (_buyPaperCost != value)
                {
                    _buyPaperCost = value;
                    PropertyHasChanged("BuyPaperCost");
                }
            }
        }

        public decimal VeneerCost
        {
            get { return _veneerCost; }
            set
            {
                if (_veneerCost != value)
                {
                    _veneerCost = value;
                    PropertyHasChanged("VeneerCost");
                }
            }
        }

        public decimal LetterPressCost
        {
            get { return _letterPressCost; }
            set
            {
                if (_letterPressCost != value)
                {
                    _letterPressCost = value;
                    PropertyHasChanged("LetterPressCost");
                }
            }
        }

        public decimal MakingTemplateCost
        {
            get { return _makingTemplateCost; }
            set
            {
                if (_makingTemplateCost != value)
                {
                    _makingTemplateCost = value;
                    PropertyHasChanged("MakingTemplateCost");
                }
            }
        }

        public decimal SahafiCost
        {
            get { return _sahafiCost; }
            set
            {
                if (_sahafiCost != value)
                {
                    _sahafiCost = value;
                    PropertyHasChanged("SahafiCost");
                }
            }
        }

        public decimal SumAll
        {
            get { return _sumAll; }
            set
            {
                if (_sumAll != value)
                {
                    _sumAll = value;
                    PropertyHasChanged("SumAll");
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
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("HasInvoice", "HasInvoice"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobId", "JobId"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PlateCost", "PlateCost"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FilmCost", "FilmCost"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CopyZinkCost", "CopyZinkCost"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("StereotypeCost", "StereotypeCost"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PrintingCost", "PrintingCost"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("BuyPaperCost", "BuyPaperCost"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("VeneerCost", "VeneerCost"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("LetterPressCost", "LetterPressCost"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MakingTemplateCost", "MakingTemplateCost"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("SahafiCost", "SahafiCost"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("SumAll", "SumAll"));
            ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description", 2147483647));
        }

        #endregion

	}
}
