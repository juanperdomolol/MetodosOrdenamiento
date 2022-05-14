using MetodosOrdenamiento;
burbuja bu = new burbuja();
shell pv = new shell();
insercion ins= new insercion();
seleccion sele = new seleccion();
try
{
    //bu.cargar();
    //bu.metodo();
    //bu.mostrar(); 
    //  pv.Cargar();
    //pv.Metodo();
    //.Imprimir();
    //ins.Cargar();
    //ins.Metodo();
    //ins.Imprimir();
    sele.Cargar();
    sele.Metodo();
    sele.Imprimir();
}
catch(Exception ex)
{
    Console.WriteLine("Escriba valores Numericos!!");
}