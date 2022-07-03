Algoritmo "AIRHORIZON"

Var
   nomes: vetor [1..3] de caracter
   destinos: vetor [1..3] de caracter
   op, nome: caracter
   i, f, c, g: inteiro
   
procedimento Inicializar ()

inicio

enquanto op <> "4" faca
              Escreval ("")
              Escreval ("AIRHORIZON")
              Escreval ("")
              Escreval (" (1) Cadastro de Clientes. ")
              Escreval (" (2) Consulta Cliente Cadastrado. ")
              Escreval (" (3) Consultar Destino")
              Escreval (" (4) Sair ")
              Escreval ("")
              Escreva  (" Opção: ")
                       leia (op)
                        Se op = "1" entao
                            limpaTela
                               Se f = 3 entao
                                   EscrevaL (" Não é mais possivel fazer Consulta")
                                   Escreval ("")
                                   Escreval ("")
                                        Senao
                                        cadastra_cliente ()
                               FimSe
                         FimSe
                         Se op = "2" entao
                            LimpaTela
                            pesquisar_cliente ()
                         FimSe
                         Se op = "3" entao
                            LimpaTela
                            pesquisar_destino()
                         FimSe
                         Se op = "4" entao
                            para i de 1 ate 3 faca
                                 nomes[i] <- "x"
                            FimPara
                                LimpaTela
                                   Escreval ("")
                                   Escreval ("Saindo Do cadastro")
                                   Escreval ("")
                         FimSe
           FimEnquanto


 FimProcedimento



 procedimento cadastra_cliente ()

Inicio

      Escreval ("")
      Escreval ("Cadastro do Cliente")
      Escreval ("")
        para i de 1 ate 3 faca
           se (nomes[i]="") entao
              Escreva ("Nome: ")
                      leia (nomes[i])
              Escreva ("Destino: ")
                      leia (destinos[i])

              f <- f + 1
                       limpaTela
           Fimse
        FimPara
               EscrevaL ("Fim Do Cadastro !")
 FimProcedimento



Procedimento pesquisar_cliente ()

inicio

      Escreval ("")
      Escreval ("Pesquisa de Clientes")
      Escreval ("")
               c <- 0
      Escreva ("Digite o Nome do Cliente: ")
              Leia (nome)
                   Para i de 1 ate 3 faca
                    Se nome = nomes[i] entao
                     EscrevaL ("Nome: ",nomes[i])
                     EscrevaL ("Destino: ",destinos[i])
                     c <- c + 1
                     FimSe
                   FimPara
                   Se c = 0 entao
                      EscrevaL ("Cliente não Cadastrado!")
                   FimSe
                   Voltar_Menu ()
                   LimpaTela
  FimProcedimento


Procedimento pesquisar_destino ()

inicio

      Escreval ("")
      Escreval ("Pesquisa de Destino")
      Escreval ("")
               g <- 0
      Escreva ("Digite o Destino: ")
              Leia (nome)
                   Para i de 1 ate 3 faca
                    Se nome = destinos[i] entao
                     EscrevaL ("Nome: ",nomes[i])
                     EscrevaL ("Destino: ",destinos[i])
                     g <- g + 1
                     FimSe
                   FimPara
                   Se g = 0 entao
                      EscrevaL ("Cliente não Cadastrado!")
                   FimSe
                   Voltar_Menu ()
                   LimpaTela
  FimProcedimento

Procedimento  Voltar_Menu ()
inicio

      Escreva ("Voltar ao Menu? (s/n): ")
              Leia (op)
              se op = "s" entao
                 LimpaTela
                       inicializar ()
                       senao
                 LimpaTela
                        pesquisar_cliente
              FimSe
  FimProcedimento

inicio

      inicializar ()

Fimalgoritmo