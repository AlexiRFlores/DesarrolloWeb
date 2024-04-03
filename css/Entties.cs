public class Conexion(){
    private string Base;
    private string Servidor;
    private string Usuario;
    private string Clave;
    private static Conexion con = null;

    public Conexion(){
        this.Base = "CRUD2";
        this.Servidor = "DESKTOP\\ALEXIFLORES";
        this.Usuario = "AlexiFlores";
        this.Clave = "Admin";
    }

    public SqlConnection CrearConexion(){
        SqlConnection Cadena = new SqlConnection();

        try{
            Cadena.Connetionstring = "Server="+this.Servidor+
                                      "; Database="+this.Base+
                                      "; User="+this.Usuario+
                                      "; Password = "+this.Clave;

        }
        catch (Exption){

            Cadena = null

        }
        return Cadena;
    }

    public Conexion GetInstancia(){
        if(Con == null){
            Con = new Conexion();
        }
        return Con;
    }
}