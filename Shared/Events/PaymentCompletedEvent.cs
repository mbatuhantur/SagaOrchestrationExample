using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events
{
    // Ödeme alındığı durumda Payment API dan State Machine Service Gönderilir.
    public class PaymentCompletedEvent : CorrelatedBy<Guid>
    {
        public PaymentCompletedEvent(Guid correlationId)
        {
            CorrelationId = correlationId;
        }
        public Guid CorrelationId { get; }
    }
}
