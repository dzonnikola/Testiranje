﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNikola
{
    public class CustomerControl
    {
        public ActionResult VratiCustomer(int id)
        {
            if(id == 0)
            {
                return new NotFound();
            }
            return new Ok();
        }

        public class ActionResult { };
        public class NotFound:ActionResult { };
        public class Ok : ActionResult { };
    }
}
