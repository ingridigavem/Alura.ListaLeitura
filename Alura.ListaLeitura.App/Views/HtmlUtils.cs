using System.IO;


namespace Alura.ListaLeitura.App.HTML {
    public class HtmlUtils {
        public static string CarregaArquivoHTML(string nomeArquivo) {
            var caminhoCompleto = $"HTML/{nomeArquivo}.html";
            using (var arquivo = File.OpenText(caminhoCompleto)) {
                return arquivo.ReadToEnd();
            }
        }
    }
}
