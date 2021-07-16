using Academy.Week1.Test.ChainPattern.Handler;

namespace Academy.Week1.Test.ChainPattern
{
    public  class CeoHandler : AbstractHandler
    {
        public override int Handle (Spesa spesa)
        {
            if (spesa.Importo > 1000)
            {
                return 3;
            }
            else
            {
                return base.Handle(spesa);
            }
        }
    }
}