namespace Domain.Transactions;

public record TransactionDto
{
    public TransactionDto(long valor, string tipo, string descricao)
    {
        Valor = valor >= 0 ?
            valor :
            throw new ArgumentOutOfRangeException(nameof(TransactionDto.Valor), "Valor must not be negative.");

        Tipo = tipo == "c" || tipo == "d" ?
            tipo :
            throw new ArgumentException("Tipo must be 'c' or 'd'.", nameof(TransactionDto.Tipo));

        Descricao = descricao;
    }

    public long Valor { get; init; }

    public string Tipo { get; init; }

    public string Descricao { get; init; }
}