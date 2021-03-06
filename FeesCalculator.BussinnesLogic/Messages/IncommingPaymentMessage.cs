using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FeesCalculator.BussinnesLogic.Messages
{
    [Serializable]
    [KnownType(typeof(OperationMessage))]
    public class IncommingPaymentMessage : OperationMessage
    {
        public IncommingPaymentMessage()
            : base(OperationMessageType.Income)
        {
        }

        [JsonIgnore]
        public override decimal Rate { get; set; }

        public override String Comment {
            get { return "������ ������ �������� ���������� � ��������� ������ �� �������� ����."; }
        }
    }
}