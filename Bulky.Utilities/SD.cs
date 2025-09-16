using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Utilities
{
    public static class SD
    {
        public const string Role_Customer = "Customer";
        public const string Role_Company = "Company";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Employee";

        public const string StatusPending = "Pending";
        public const string StatusApproved = "Approved";
        public const string StatusInProcess = "Processing";
        public const string StatusShipped = "Shipped";
        public const string StatusCacelled = "Cancelled";
        public const string StatusRefunded = "Refunded";

        public const string PaymentStatusPending = "PaymentPending";
        public const string PaymentStatusApproved = "PaymentApproved";
        public const string PaymentStatusDelayedPayment = "PaymentDelayed";
        public const string PaymentStatusRejected = "PaymenRejected";

        public const string SessionCart = "SessionShoppingCart";

    }
}
