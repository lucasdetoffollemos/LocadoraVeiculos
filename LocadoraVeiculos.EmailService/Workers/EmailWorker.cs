using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using LocadoraVeiculos.netCore.Dominio.LocacaoModule;

namespace LocadoraVeiculos.EmailService.Workers
{
    public class EmailWorker : BackgroundService
    {
        private readonly ILogger<EmailWorker> _logger;
        private readonly INotificadorEmail _notificadorEmail;
        private readonly IVerificadorConexao _verificadorConexao;

        public EmailWorker(ILogger<EmailWorker> logger, INotificadorEmail notificadorEmail, IVerificadorConexao verificadorConexao)
        {
            _logger = logger;
            _notificadorEmail = notificadorEmail;
            _verificadorConexao = verificadorConexao;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                ConcurrentBag<Email> emails = new ConcurrentBag<Email>(_notificadorEmail.ObterEmailsAgendados());

                if (emails.Count == 0)
                {
                    _logger.LogInformation("N�o h� emails � serem enviados, aguardando 1 minuto...");

                    await Task.Delay(100000, stoppingToken);
                    continue;
                }
                else if (_verificadorConexao.TemConexaoComInternet() == false)
                {
                    _logger.LogInformation("Falha ao se conectar com o servi�o de email, n�o h� conex�o com a internet..."); ;

                    await Task.Delay(100000, stoppingToken);
                    continue;
                }

                try
                {
                    Parallel.ForEach(emails, (email) =>
                    {
                        bool conseguiuEnviar = _notificadorEmail.EnviarEmailAgendado(email);

                        if (conseguiuEnviar)
                            _logger.LogInformation("Email enviado ao endere�o {enderecoEmail} com sucesso!", email.EmailCliente);
                        else
                            _logger.LogError("Falha ao enviar email ao endere�o {enderecoEmail}!", email.EmailCliente);

                    });
                }
                catch (Exception)
                {
                    _logger.LogError("Houve um erro inesperado ao tentar enviar o email!");
                }
            }
        }
    }
}
