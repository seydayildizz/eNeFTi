using eNeFTi_EL;
using eNeFTi_EL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_BLL.EmailService
{
    public interface IEMailSender
    {
        Task SendAsync(EMailMessage message);

        void SendOrderPdf(EMailMessage message, OrderViewModel data);

        Task SendOrderPdfAsync(EMailMessage message, OrderViewModel data);
    }
}
