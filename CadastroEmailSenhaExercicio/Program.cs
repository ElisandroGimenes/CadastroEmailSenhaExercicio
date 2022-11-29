class program
{
    static void Main()
    {

    //Cadastro email

    Cadastro1:
        Console.Write("Cadastre seu e-mail: ");
        var email = Console.ReadLine();
        if (email.Contains('@'))
        {
            Console.WriteLine("E-mail cadastrado com sucesso!");
            goto Cadastro2;
        }
        else
        {
            Console.WriteLine("E-mail inválido! Por favor cadastre um e-mail válido: ");
            goto Cadastro1;
        }

    //Cadastro senha

    Cadastro2:
        Console.Write("Cadastre sua senha: ");
        var senha = Console.ReadLine();
        Console.WriteLine("Cadastro efetuado com sucesso!");
    Login:
        Console.Write("Digite 1 para acessar sua conta ou 2 para sair: ");
        var opcao = Console.ReadLine();
        if (opcao.Equals("1"))
        {
            goto Log;
        }
        else if (opcao.Equals("2"))
        {
            goto Fim;
        }
        else
        {
            Console.WriteLine("Opção inválida!");
            goto Login;
        }

    //Acesso email e senha

    Log:
        Console.Write("Digite seu e-mail: ");
        var mail = Console.ReadLine();

        Console.Write("Digite sua senha: ");
        var pass = Console.ReadLine();

        if (pass.Equals(senha) && mail.Equals(email))
        {
            Console.WriteLine("Acesso liberado!");
        Out:
            Console.Write("Digite 9 para sair. ");
            var sair = Console.ReadLine();
            if (sair.Equals("9"))
            {
                goto Fim;
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                goto Out;
            }
        }
        else
        {
            Console.WriteLine("E-mail ou Senha incorretos! Tente novamente: ");
            goto Log;
        }
    Fim:
        Console.Write("Obrigado, volte sempre!");
    }
}
