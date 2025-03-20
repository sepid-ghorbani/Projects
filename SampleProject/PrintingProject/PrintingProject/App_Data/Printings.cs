using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Printings: BusinessObjectBase
	{

		#region InnerClass
		public enum PrintingsFields
		{
			Id,
			JobId,
			Row,
			Printing,
			Dimension,
			OrderReceiverId,
			PrintTypeId,
			ZinkTypeId,
			PrintModelId,
			MaterialTypeId,
			MaterialTypeGramazhId,
			LargePaperCount,
			LargePaperSize,
			PaperParagraphCount,
			ParagraphLeafCount,
			PrintingTirazh,
			MainColorCountId,
			ExportColorId,
			SpotColorCountId,
			SpotColors,
			PrintingSupervision,
			ColorInstance,
			DeviceCount,
			FormEvertCount,
			Description,
			InvoiceRow,
			InvoiceNum,
			InvoiceCost,
			IsUse,
            PaperWidthId,
            PaperHeightId,
            FromInstituteId
		}
		#endregion

		#region Data Members

			int _id;
			int _jobId;
			int _row;
			int _printing;
			string _dimension;
			int _orderReceiverId;
			int _printTypeId;
			int _zinkTypeId;
			int _printModelId;
			int _materialTypeId;
			int _materialTypeGramazhId;
			int? _largePaperCount;
			string _largePaperSize;
            double? _paperParagraphCount;
			int? _paragraphLeafCount;
			int? _printingTirazh;
			int? _mainColorCountId;
			int _exportColorId;
			int? _spotColorCountId;
			string _spotColors;
			bool _printingSupervision;
			int _colorInstance;
			int? _deviceCount;
			double? _formEvertCount;
			string _description;
			string _invoiceRow;
			string _invoiceNum;
			decimal? _invoiceCost;
			bool? _isUse;
            int _paperWidthId;
            int _paperHeightId;
            int _fromInstituteId;

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

		public int  Row
		{
			 get { return _row; }
			 set
			 {
				 if (_row != value)
				 {
					_row = value;
					 PropertyHasChanged("Row");
				 }
			 }
		}

		public int  Printing
		{
			 get { return _printing; }
			 set
			 {
				 if (_printing != value)
				 {
					_printing = value;
					 PropertyHasChanged("Printing");
				 }
			 }
		}

		public string  Dimension
		{
			 get { return _dimension; }
			 set
			 {
				 if (_dimension != value)
				 {
					_dimension = value;
					 PropertyHasChanged("Dimension");
				 }
			 }
		}

		public int  OrderReceiverId
		{
			 get { return _orderReceiverId; }
			 set
			 {
				 if (_orderReceiverId != value)
				 {
					_orderReceiverId = value;
					 PropertyHasChanged("OrderReceiverId");
				 }
			 }
		}

		public int  PrintTypeId
		{
			 get { return _printTypeId; }
			 set
			 {
				 if (_printTypeId != value)
				 {
					_printTypeId = value;
					 PropertyHasChanged("PrintTypeId");
				 }
			 }
		}

		public int  ZinkTypeId
		{
			 get { return _zinkTypeId; }
			 set
			 {
				 if (_zinkTypeId != value)
				 {
					_zinkTypeId = value;
					 PropertyHasChanged("ZinkTypeId");
				 }
			 }
		}

		public int  PrintModelId
		{
			 get { return _printModelId; }
			 set
			 {
				 if (_printModelId != value)
				 {
					_printModelId = value;
					 PropertyHasChanged("PrintModelId");
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

		public int?  LargePaperCount
		{
			 get { return _largePaperCount; }
			 set
			 {
				 if (_largePaperCount != value)
				 {
					_largePaperCount = value;
					 PropertyHasChanged("LargePaperCount");
				 }
			 }
		}

		public string  LargePaperSize
		{
			 get { return _largePaperSize; }
			 set
			 {
				 if (_largePaperSize != value)
				 {
					_largePaperSize = value;
					 PropertyHasChanged("LargePaperSize");
				 }
			 }
		}

        public double? PaperParagraphCount
		{
			 get { return _paperParagraphCount; }
			 set
			 {
				 if (_paperParagraphCount != value)
				 {
					_paperParagraphCount = value;
					 PropertyHasChanged("PaperParagraphCount");
				 }
			 }
		}

		public int?  ParagraphLeafCount
		{
			 get { return _paragraphLeafCount; }
			 set
			 {
				 if (_paragraphLeafCount != value)
				 {
					_paragraphLeafCount = value;
					 PropertyHasChanged("ParagraphLeafCount");
				 }
			 }
		}

		public int?  PrintingTirazh
		{
			 get { return _printingTirazh; }
			 set
			 {
				 if (_printingTirazh != value)
				 {
					_printingTirazh = value;
					 PropertyHasChanged("PrintingTirazh");
				 }
			 }
		}

		public int?  MainColorCountId
		{
			 get { return _mainColorCountId; }
			 set
			 {
				 if (_mainColorCountId != value)
				 {
					_mainColorCountId = value;
					 PropertyHasChanged("MainColorCountId");
				 }
			 }
		}

		public int  ExportColorId
		{
			 get { return _exportColorId; }
			 set
			 {
				 if (_exportColorId != value)
				 {
					_exportColorId = value;
					 PropertyHasChanged("ExportColorId");
				 }
			 }
		}

		public int?  SpotColorCountId
		{
			 get { return _spotColorCountId; }
			 set
			 {
				 if (_spotColorCountId != value)
				 {
					_spotColorCountId = value;
					 PropertyHasChanged("SpotColorCountId");
				 }
			 }
		}

		public string  SpotColors
		{
			 get { return _spotColors; }
			 set
			 {
				 if (_spotColors != value)
				 {
					_spotColors = value;
					 PropertyHasChanged("SpotColors");
				 }
			 }
		}

		public bool  PrintingSupervision
		{
			 get { return _printingSupervision; }
			 set
			 {
				 if (_printingSupervision != value)
				 {
					_printingSupervision = value;
					 PropertyHasChanged("PrintingSupervision");
				 }
			 }
		}

		public int  ColorInstance
		{
			 get { return _colorInstance; }
			 set
			 {
				 if (_colorInstance != value)
				 {
					_colorInstance = value;
					 PropertyHasChanged("ColorInstance");
				 }
			 }
		}

		public int?  DeviceCount
		{
			 get { return _deviceCount; }
			 set
			 {
				 if (_deviceCount != value)
				 {
					_deviceCount = value;
					 PropertyHasChanged("DeviceCount");
				 }
			 }
		}

		public double?  FormEvertCount
		{
			 get { return _formEvertCount; }
			 set
			 {
				 if (_formEvertCount != value)
				 {
					_formEvertCount = value;
					 PropertyHasChanged("FormEvertCount");
				 }
			 }
		}

		public string  Description
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

		public string  InvoiceRow
		{
			 get { return _invoiceRow; }
			 set
			 {
				 if (_invoiceRow != value)
				 {
					_invoiceRow = value;
					 PropertyHasChanged("InvoiceRow");
				 }
			 }
		}

		public string  InvoiceNum
		{
			 get { return _invoiceNum; }
			 set
			 {
				 if (_invoiceNum != value)
				 {
					_invoiceNum = value;
					 PropertyHasChanged("InvoiceNum");
				 }
			 }
		}

		public decimal?  InvoiceCost
		{
			 get { return _invoiceCost; }
			 set
			 {
				 if (_invoiceCost != value)
				 {
					_invoiceCost = value;
					 PropertyHasChanged("InvoiceCost");
				 }
			 }
		}

		public bool?  IsUse
		{
			 get { return _isUse; }
			 set
			 {
				 if (_isUse != value)
				 {
					_isUse = value;
					 PropertyHasChanged("IsUse");
				 }
			 }
		}
        public int PaperWidthId
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

        public int PaperHeightId
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

        public int FromInstituteId
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobId", "JobId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Row", "Row"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Printing", "Printing"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Dimension", "Dimension",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OrderReceiverId", "OrderReceiverId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PrintTypeId", "PrintTypeId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ZinkTypeId", "ZinkTypeId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PrintModelId", "PrintModelId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MaterialTypeId", "MaterialTypeId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MaterialTypeGramazhId", "MaterialTypeGramazhId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("LargePaperSize", "LargePaperSize",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ExportColorId", "ExportColorId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("SpotColors", "SpotColors",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PrintingSupervision", "PrintingSupervision"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ColorInstance", "ColorInstance"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceRow", "InvoiceRow",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceNum", "InvoiceNum",50));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PaperWidthId", "PaperWidthId"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PaperHeightId", "PaperHeightId"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FromInstituteId", "FromInstituteId"));

		}

		#endregion

	}
}
