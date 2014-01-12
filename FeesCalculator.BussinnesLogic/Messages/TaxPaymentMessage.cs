using System;
using FeesCalculator.Data;

namespace FeesCalculator.BussinnesLogic.Messages
{
    public class TaxPaymentMessage : OperationMessage
    {
        public TaxPaymentMessage(): base(OperationMessageType.Tax)
        {
            
        }

        public QuarterType QuarterType { get; set; }

        public int YearNumber { get; set; }


        public override string Comment {
            get
            {
                return  String.Format("������ ������ �� {0} ������� {1} ����.", ((int)QuarterType).ToString(), YearNumber);
            }
        }
    }
}