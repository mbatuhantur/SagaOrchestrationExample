using MassTransit;
using Shared.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events
{
    // Ödeme alınamadığı durumda Payment API dan State Machine Service'e gönderilir.
    public class PaymentFailedEvent : CorrelatedBy<Guid>
    {
        public PaymentFailedEvent(Guid correlationId)
        {
            CorrelationId = correlationId;
        }
        public Guid CorrelationId { get; }

        public int OrderId { get; set; }
        public string Message { get; set; }
    }
}
