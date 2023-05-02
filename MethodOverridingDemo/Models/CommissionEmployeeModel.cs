namespace MethodOverridingDemo
{
    public class CommissionEmployeeModel : EmployeeModel
    {
        public decimal CommisionAmount { get; set; }

        public override decimal GetPayCheckAmount(int hoursWorked)
        {
            decimal initialPay = base.GetPayCheckAmount(hoursWorked);
            return initialPay + CommisionAmount;
        }
    }
}
