namespace SmartUtilityBillingCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessBilling_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text;
            string input = txtMeterReadings.Text;

            string[] values = input.Split(
            new char[] { ',' },
            StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();
            }

            double[] readings = new double[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                readings[i] = double.Parse(values[i]);
            }

            BillingEngine engine = new BillingEngine();

            double usage = engine.CalculateUsage(readings);
            double subtotal = engine.CalculateSubtotal(usage);
            double tax = engine.CalculateTax(subtotal);
            double total = engine.CalculateTotal(subtotal);

            rtbOutput.Clear();
            rtbOutput.AppendText($"Customer: {accountName}\n");
            rtbOutput.AppendText($"Usage: {usage}\n");
            rtbOutput.AppendText($"Subtotal: {subtotal:C}\n");
            rtbOutput.AppendText($"Tax: {tax:C}\n");
            rtbOutput.AppendText($"Total: {total:C}\n");
        }
    }
}
