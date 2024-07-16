namespace Talents
{
    public class Calculadora
    {
        private List<string> _hist;

        public Calculadora()
        {
            _hist = new List<string>();
        }

        public string teste() { return "Teste"; }
        public int Somar(int num1, int num2)
        {

            int res = num1 + num2;
            string operacao = $"Somar: {num1} + {num2} = {res}";
            _hist.Add(operacao);
            return res;
        }
        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            string operacao = $"Subtrair: {num1} + {num2} = {res}";
            _hist.Add(operacao);
            return res;
        }
        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            string operacao = $"Multiplicar: {num1} * {num2} = {res}";
            _hist.Add(operacao);
            return res;
        }
        public int Dividir(int num1, int num2)
        {
            int res = num1 / num2;
            string operacao = $"Dividir: {num1} / {num2} = {res}";
            _hist.Add(operacao);
            return res;
        }

        public List<string> ObterHistoricoOperacoes()
        {
            return _hist;
        }
        public List<string> Historico()
        {

            return ObterHistoricoOperacoes().TakeLast(3).ToList();

        }


    }


}