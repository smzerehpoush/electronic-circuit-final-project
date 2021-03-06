﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace circuit_project.Pages
{
    public class ElectronConfigurationModel : PageModel
    {
        private readonly ILogger<ElectronConfigurationModel> _logger;

        public ElectronConfigurationModel(ILogger<ElectronConfigurationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}