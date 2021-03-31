using System;
using System.Collections.Generic;

using CSharp.ClassesEMetodos;
using CSharp.Colecoes;
using CSharp.EstruturaDeControle;
using CSharp.Fundamentos;
using CSharp.OO;
using CSharp.MetodosEFuncoes;
using CSharp.Excecoes;
using CSharp.Api;
using CSharp.Avancados;

namespace CursoCSharp
{
	class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // -- Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
				{"Comentários - Fundamentos", Comentarios.Executar},
				{"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
				{"Inferência - Fundamentos", Inferencia.Executar},
				{"Interpolação - Fundamentos", Interpolacao.Executar},
				{"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
				{"Lendo Dados - Fundamentos", LendoDados.Executar},
				{"Formatando Número - Fundamentos", FormatandoNumero.Executar},
				{"Conversões - Fundamentos", Conversoes.Executar},
				{"Operadores Aritméricos - Fundamentos", OperadoresAritmeticos.Executar},
				{"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
				{"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
				{"Operadores de Atribuição - Fundamentos", OperadoresLogicos.Executar},
				{"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                // -- Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                // -- Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos- Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Parâmetros Variáveis - Classes e Metodos", Parametros.Executar},
                {"Parâmetros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Metodos", GetSet.Executar},
                {"Propriedades - Classes e Metodos", Propriedades.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", ExempEnums.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Parametros por Referência - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametros Padrão - Classes e Metodos", ParametrosPorReferencia.Executar},

                // -- Coleções
                {"Array - Coleções", CSharp.Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesList.Executar},
                {"Set - Coleções", ColecoesSet2.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", Dictionary.Executar},

                // -- Orientação a Objetos
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Abstract.Executar},
                {"Sealed - OO", Sealed.Executar},

                // -- Metodos & Funções
                {"Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar},
                {"Lambdas Como Delegates - Métodos & Funções", ExemploLambda.Executar},
                {"Usando Delegates - Métodos & Funções", UsandoDelegates.Executar},
                {"Delegates como Função Anonima - Métodos & Funções", UsandoDelegates.Executar},
                {"Delegates como Parametros - Métodos & Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar},

                // -- Exeções
                // -- Exeções
                {"Métodos de Extensão - Métodos & Funções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Métodos & Funções", ExcecoesPersonalizadas.Executar},

                // -- API
                {"Primeiro Arquivo - Usando Api", PrimeiroArquivo.Executar},
                {"Lendo Arquivo - Usando Api", PrimeiroArquivo.Executar},
                {"Exemplo File Info - Usando Api", PrimeiroArquivo.Executar},
                {"Diretórios - Usando Api", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Usando Api", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando Api", ExemploPath.Executar},
                {"Exemplo `TimeSpan - Usando Api", ExemploTimeSpan.Executar},

                // -- Tópicos Avançados
                {"LINQ #01 - Avançados", LINQ1.Executar},
                {"LINQ #02 - Avançados", LINQ2.Executar},
                {"Nullabes - Avançados", LINQ2.Executar},
                {"Dynamics - Avançados", Dynamic.Executar},
                {"Generics - Avançados", Generic.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}