using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TCC.ApplicationCore.Entity;
using TCC.Infrasctructure.Data;

namespace TCC.UI.Web.Controllers
{
    public class EmailConfigsController : Controller
    {
        private readonly Context _context;

        public EmailConfigsController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Details()
        {
            var emailConfig = await _context.EmaiilConfig
                .FirstOrDefaultAsync();

            if (emailConfig == null)
            {
                emailConfig = new EmailConfig();
                _context.Add(emailConfig);
                _context.SaveChanges();
            }

            return View(emailConfig);
        }

        public async Task<IActionResult> Edit()
        {
            var emailConfig = await _context.EmaiilConfig.FirstOrDefaultAsync();
            if (emailConfig == null)
            {
                emailConfig = new EmailConfig();
                _context.Add(emailConfig);
                _context.SaveChanges();
            }
            return View(emailConfig);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmailConfigId,CredentialUserName,CredentialPassword,Subject,Body,SmtpClient,PortSSL")] EmailConfig emailConfig)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emailConfig);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmailConfigExists(emailConfig.EmailConfigId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details));
            }
            return View(emailConfig);
        }

        private bool EmailConfigExists(int id)
        {
            return _context.EmaiilConfig.Any(e => e.EmailConfigId == id);
        }
    }
}
