﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;
using WorkflowCore.Models.Search;

namespace WorkflowCore.Services
{
    public class InMemorySearchIndex : ISearchIndex
    {
        public Task IndexWorkflow(WorkflowInstance workflow)
        {
            return Task.CompletedTask;
        }

        public Task<Page<WorkflowSearchResult>> Search(string terms, int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task Start()
        {
            return Task.CompletedTask;
        }

        public Task Stop()
        {
            return Task.CompletedTask;
        }
    }
}
