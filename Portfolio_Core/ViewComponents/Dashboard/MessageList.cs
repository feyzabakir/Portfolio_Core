using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Core.ViewComponents.Dashboard
{
    public class MessageList: ViewComponent
    {
        UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.GetUserMessageWithUserService();
            return View(values);
        }
    }
}
