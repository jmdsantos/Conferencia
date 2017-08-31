namespace pesquisarJogo.Controle
{
    /// <summary>
    /// Classe de atributos e métodos dos Parâmetros
    /// </summary>
    public class Parametros
    {
        private string _arquivo;
        private string _delimitador;
        private string _jogoInicio;
        private string _jogoFim;
        private string _noJogo;

        public string Arquivo { get => _arquivo; set => _arquivo = value; }
        public string Delimitador { get => _delimitador; set => _delimitador = value; }
        public string JogoInicio { get => _jogoInicio; set => _jogoInicio = value; }
        public string JogoFim { get => _jogoFim; set => _jogoFim = value; }
        public string NoJogo { get => _noJogo; set => _noJogo = value; }
    }
}
