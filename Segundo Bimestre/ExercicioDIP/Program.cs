using ExercicioDIP;

INFDao dao = new NFDao();
ICalculadorDeImposto impostos = new CalculadorDeImposto();
ICorreios correios = new Correios();
ILeiDeEntrega lei = new LeiDeEntrega();

EntregadorDeNFs entregador = new EntregadorDeNFs(correios,lei);

DespachadorDeNotasFiscais despachador = new DespachadorDeNotasFiscais(dao,impostos,entregador);
NotaFiscal nf = new NotaFiscal("001",1000.00);
despachador.Processa(nf);
Console.WriteLine("Nota fiscal processada!");