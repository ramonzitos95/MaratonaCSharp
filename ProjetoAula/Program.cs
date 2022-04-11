using ProjetoAula;

var casaNova = new Casa();
casaNova.Tamanho = 100;
casaNova.ValorCasa = 250.000M;
casaNova.Cor = "Azul";
casaNova.CasaAlugada = true;

if(casaNova.CasaAlugada)
    casaNova.AlugarCasa();
else
    casaNova.VenderCasa();
