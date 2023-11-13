namespace LabSchool.Extensions;

public static class StringExtension
{
    private static List<String> _tipoSituacao = new List<string>
    {
        "ATIVO",
        "INATIVO",
        "ATENDIMENTO PEDAGÓGICO",
        "IRREGULAR"
    };

    public static bool ValidarSituacao(this string situacao)
    {
        return _tipoSituacao.Any(p => p == situacao?.ToUpper());
    }
}
