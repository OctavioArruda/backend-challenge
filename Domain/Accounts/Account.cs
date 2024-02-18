using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Accounts;

[Table("clientes")]
public record Account
{
    public Account(long id, long limite, long saldo)
    {
        Id = id;
        Limite = limite;
        Saldo = saldo;
    }

    [Column("id")]
    public long Id { get; set; }

    [Column("limite")]
    public long Limite { get; set; }

    [Column("saldo")]
    public long Saldo { get; set; }
}