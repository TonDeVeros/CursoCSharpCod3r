using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.Excecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa      - Fundamentos" , PrimeiroPrograma.Executar},
                {"Comentarios            - Fundamentos" , Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos" , VariaveisEConstantes.Executar },
                {"Notação Ponto          - Fundamentos" , NotacaoPonto.Executar },
                {"Lendo Dados            - Fundamentos" , LendoDados.Executar },
                {"Formatando número      - Fundamentos" , FormatandoNumero.Executar },
                {"Conversões             - Fundamentos" , Conversoes.Executar },
                {"OperadoresAritmeticos  - Fundamentos" , OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos" , OperadoresRelacionais.Executar },
                {"Operadores Lógicos     - Fundamentos" , OperadoresLogicos.Executar },
                {"Operadores Atribuição  - Fundamentos" , OperadoresAtribuicao.Executar },
                {"Operadores Unários     - Fundamentos" , OperadoresAtribuicao.Executar },
                {"Operadores Ternario    - Fundamentos" , OperadorTernario.Executar },
                
                // Estruturas de Controle
                {"Estrutura If       - Estruturas de Controle" , EstruturaIf.Executar },
                {"Estrutura IfElse   - Estruturas de Controle" , EstruturaIfElse.Executar },
                {"Estrutura IfElseIf - Estruturas de Controle" , EstruturaIfElseIf.Executar },
                {"Estrutura Switch   - Estruturas de Controle" , EstruturaSwitch.Executar },
                {"Estrutura While    - Estruturas de Controle" , EstruturaWhile.Executar },
                {"Estrutura DoWhile  - Estruturas de Controle" , EstruturaDoWhile.Executar },
                {"Estrutura For      - Estruturas de Controle" , EstruturaFor.Executar },
                {"Estrutura ForEach  - Estruturas de Controle" , EstruturaForEach.Executar },
                {"Usando Break       - Estruturas de Controle" , UsandoBreak.Executar },
                {"Usando Continue    - Estruturas de Controle" , UsandoContinue.Executar },

                //Classes e Métodos
                {"Membros               - Classes e Métodos" , Membros.Executar },
                {"Construtores          - Classes e Métodos" , Construtores.Executar },
                {"Metodos Com Retorno   - Classes e Métodos" , MetodosComRetorno.Executar },
                {"Metodos Estáticos     - Classes e Métodos" , MetodosEstaticos.Executar },
                {"Atributos Estáticos   - Classes e Métodos" , AtributosEstaticos.Executar },
                {"Desafio Atributo      - Classes e Métodos" , DesafioAtributo.Executar },
                {"Params                - Classes e Métodos" , Params.Executar },
                {"Parametros Nomeados   - Classes e Métodos" , ParametrosNomeados.Executar },
                {"Get Set               - Classes e Métodos" , GetSet.Executar },
                {"Props                 - Classes e Métodos" , Props.Executar },
                {"Readonly              - Classes e Métodos" , Readonly.Executar },
                {"Enum                  - Classes e Métodos" , Enumeracao.Executar },
                {"Struct                - Classes e Métodos" , ExemploStruct.Executar },
                {"Struct VS Classe      - Classes e Métodos" , StructVsClasse.Executar },
                {"Valor VS Referência   - Classes e Métodos" , ValorVsReferencia.Executar },
                {"Parametros por Referência - Classes e Métodos" , ParametrosPorReferencia.Executar },
                {"Parametros padrão     - Classes e Métodos" , ParametroPadrao.Executar },

                //Coleções
                {"Array - Coleções" , UsandoArray.Executar },
                {"List - Coleções" , ColecoesList.Executar },
                {"ArrayList - Coleções" , ColecoesArrayList.Executar },
                {"Set - Coleções" , ColecoesSet.Executar },
                {"Queue - Coleções" , ColecoesQueue.Executar },
                {"Igualdade - Coleções" , Igualdade.Executar },
                { "Colecao Stack - Coleções", ColecoesStack.Executar },
                { "Colecao Dictionary - Coleções", ColecoesDictionary.Executar },

                //OO
                {"Herança - OO", Heranca.Executar },
                {"Construtor This - OO", ConstrutorThis.Executar },
                {"Encapsulamento - OO", OO.Encapsulamento.Executar },
                {"Polimorfismo  - OO", Polimorfismo.Executar },
                {"Classe Abstrata  - OO", Abstract.Executar },
                {"Interface  - OO", Interface.Executar },
                {"Classe Sealed  - OO", Sealed.Executar },


                //Métodos & Funcoes
                {"Exemplo Lambda  - Métodos e Funcoes", ExemploLambda.Executar },
                {" Lambda como Delegates  - Métodos e Funcoes", LambdasDelegate.Executar },
                {" Usando Delegate  - Métodos e Funcoes", UsandoDelegate.Executar },
                {"  Delegates como Funcao Anonima  - Métodos e Funcoes", DelegateFuncAnonima.Executar },
                {"  Delegates como Parametros - Métodos e Funcoes", DelegatesComoParametros.Executar },
                {" Métodos de Extenção - Métodos e Funcoes", MetodosDeExtensao.Executar },



    
                //{"Primeira Exceção - Exceções", PrimeiraExcecao.Executar }

            });

            central.SelecionarEExecutar();
        }
    }
}