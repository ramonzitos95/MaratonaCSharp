
public class static ControleDeSessao 
{
  private bool VerificarSessao()
  {
      if (Session["LastAccessTime"] == null)
      {https://github.com/ramonzitos95/MaratonaC-/blob/main/ProjetoAula/ControleDeSessao
          Session["LastAccessTime"] = DateTime.Now;
          return true;
      }
      else
      {
          DateTime lastAccessTime = (DateTime)Session["LastAccessTime"];
          DateTime currentTime = DateTime.Now;
  
          // Verifica se o tempo desde a última atualização é maior ou igual a 20 minutos
          if ((currentTime - lastAccessTime).TotalMinutes >= 20)
          {
              // Atualiza o tempo de última visita
              Session["LastAccessTime"] = currentTime;
              return true;
          }
          else
          {
              return false;
          }
      }
  }

}
