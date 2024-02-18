using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Transactions;

[Table("transacoes")]
public record Transaction
{
    public Transaction(long valor, string tipo, string descricao, long clientId)
    {
        Valor = valor >= 0 ?
            valor :
            throw new ArgumentOutOfRangeException(nameof(Transaction.Valor), "Valor must not be negative.");

        Tipo = tipo == "c" || tipo == "d" ?
            tipo :
            throw new ArgumentException("Tipo must be 'c' or 'd'.", nameof(Transaction.Tipo));

        Descricao = descricao;
        ClientId = clientId;
    }

    [Column("id")]
    public long Id { get; set; }

    [Column("cliente_id")]
    public long ClientId { get; set; }

    [Column("valor")]
    public long Valor { get; init; }

    [Column ("tipo")]
    public string Tipo { get; init; }

    [Column("descricao")]
    public string Descricao { get; init; }

    [Column("realizada_em")]
    public DateTimeOffset Date { get; set; }
}