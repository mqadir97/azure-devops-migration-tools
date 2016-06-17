﻿using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _VSTS.DataBulkEditor.Engine.ComponentContext
{
   public interface IFieldMap
    {
        void Execute(WorkItem source, WorkItem target);
    }
}
