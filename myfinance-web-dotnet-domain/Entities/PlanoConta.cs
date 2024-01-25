namespace myfinance_web_dotnet_domain;

using myfinance_web_dotnet_domain.Entities.Base;

public class PlanoConta : EntityBase
{
    public string Descricao { get; set; }
    public string Tipo { get; set; }
}
