﻿namespace myfinance_web_dotnet_domain;

public class Transacao
{
    public int? Id { get; set; }
    public string Historico { get; set; }
    public DateTime Data { get; set; }
    public decimal Valor { get; set; }
    public int PlanoConta_Id { get; set; }
    public PlanoConta PlanoConta { get; set; }
}
