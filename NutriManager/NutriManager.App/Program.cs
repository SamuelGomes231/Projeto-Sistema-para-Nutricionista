using NutriManager.App.Infra;
using Microsoft.Extensions.DependencyInjection; // Necessário para o GetService
using System;
using System.Windows.Forms;

namespace NutriManager.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. OBRIGATÓRIO: Configura toda a injeção de dependência (Banco, Services, Forms)
            ConfigureDI.ConfigureServices();

            // 2. Verifica se a configuração funcionou
            if (ConfigureDI.serviceProvider == null)
            {
                MessageBox.Show("Erro crítico: O Provider de serviços não foi inicializado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Pega o MainForm já pronto de dentro da Injeção de Dependência
            var mainForm = ConfigureDI.serviceProvider.GetService<MainForm>();

            // 4. Roda a aplicação
            Application.Run(mainForm);
        }
    }
}