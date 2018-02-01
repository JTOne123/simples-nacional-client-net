namespace ACL.SimplesNacional.Client.Sublimites
{
    /// <summary>
    /// Retorno da API de an�lise de sublimites
    /// </summary>
    public class AnaliseSublimite
    {
        /// <summary>
        /// Ano da compet�ncia respons�vel pelo enquadramento
        /// </summary>
        public int Ano { get; set; }

        /// <summary>
        /// Cnpj do contribuinte enquadrado
        /// </summary>
        public string Cnpj { get; set; }

        /// <summary>
        /// M�s da compet�ncia respons�vel pelo enquadramento
        /// </summary>
        public int Mes { get; set; }

        /// <summary>
        /// Valor do sublimite estadual ou nacional
        /// </summary>
        public double Sublimite { get; set; }

        /// <summary>
        /// Receita bruta do ano-calend�rio para o mercado externo
        /// </summary>
        public double RBAExterno { get; set; }

        /// <summary>
        /// Receita bruta do ano-calend�rio para o mercado interno
        /// </summary>
        public double RBAInterno { get; set; }
    }
}