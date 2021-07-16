using Academy.Week1.Test.ChainPattern.Handler;

namespace Academy.Week1.Test.ChainPattern
{
    public  class OperationManagerHandler : AbstractHandler 
    {
        public override int Handle(Spesa spesa)
        {
            if (spesa.Importo > 401)
            {
                return 2;
            }
            else
            {
                return base.Handle(spesa);
            }

        }
    }
}