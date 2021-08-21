using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Statiq.App;
using Statiq.Web;
using Statiq.Common;

namespace MySite
{
  public class Program
  {
    public static async Task<int> Main(string[] args) 
    {

      return await Bootstrapper
              .Factory
              .CreateWeb(args)
              .DeployToGitHubPages(
                  "juanjuanzero",
                  "JuanSmallStep.github.io",
                  Config.FromSetting<string>("GITHUB_TOKEN")
              )
              .RunAsync();
    }
      
  }
}
