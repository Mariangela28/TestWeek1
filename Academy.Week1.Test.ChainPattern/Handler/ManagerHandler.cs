using Academy.Week1.Test.ChainPattern.Handler;

namespace Academy.Week1.Test.ChainPattern
{
    public class ManagerHandler : AbstractHandler
    {
        public override int Handle(Spesa spesa)
        {
            if (spesa.Importo <= 400)
            {
                return 1;
            }
            else
            {
                return base.Handle(spesa);
            }

        }
    }
}