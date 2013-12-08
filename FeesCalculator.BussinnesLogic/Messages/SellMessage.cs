using System;
using System.Runtime.Serialization;
using FeesCalculator.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FeesCalculator.BussinnesLogic.Messages
{
    [Serializable]
    [KnownType(typeof(OperationMessage))]
    public class SellMessage: OperationMessage
    {
        public SellMessage()
            : base(OperationMessageType.Sell)
        {
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public SellType SellType { get; set; }

        public override String Comment
        {
            get
            {
                return String.Format("������ �������� ��������� ���������� �� {0} ������� ������. {1}",
                    SellType == SellType.Mandatory ? "������������ (30%)" : "���������", 
                    SellType == SellType.Mandatory ? "���� ����� ���� �� ���. ����� �� ���� �������." : "���� ������� ������ ���� ������ � ������� ��������.");
            }
        }
    }
}