// See https://aka.ms/new-console-template for more information

string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
{
    double imc = pesoDoUsuario / (alturaDoUsuario * alturaDoUsuario);

    if (imc < 18.5)
    {
        return "Abaixopeso";
    }else if (imc >= 18.5 && imc <= 24.9)
    {
        return "Normal";
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        return "Sobrepeso";
    }
    else if (imc >= 30 && imc < 40 )
    {
        return "Obesidade";
    }
    else
    {
        return "Obesidade grave";
    }

}

Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(1.70, 105)}");
