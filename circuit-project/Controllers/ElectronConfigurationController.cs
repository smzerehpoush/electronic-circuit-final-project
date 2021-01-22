using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    [ApiController]
    [Route("api/v1/electron-configuration")]
    public class ElectronConfigurationController : ControllerBase
    {
        private readonly ILogger<ElectronConfigurationController> _logger;

        public ElectronConfigurationController(ILogger<ElectronConfigurationController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{count}")]
        public IActionResult Get(int count)
        {
            return Ok($"Hello {count}");
        }

        private readonly Dictionary<int, string> electronConfigurations = new Dictionary<int, string>()
        {
                    {1, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">2 He <a href=\"#\" title=\"هلیوم\">هلیوم</a>&nbsp;: 1s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {2, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">2 He <a href=\"#\" title=\"هلیوم\">هلیوم</a>&nbsp;: 1s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {3, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">3 Li <a href=\"#\" class=\"mw-redirect\" title=\"لیتیوم\">لیتیوم</a>&nbsp;: 1s<sup>2</sup> 2s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">1</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {4, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">4 Be <a href=\"#\" class=\"mw-redirect\" title=\"برلیم\">برلیم</a>&nbsp;: 1s<sup>2</sup> 2s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">2</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {5, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">5 B <a href=\"#\" title=\"بور\">بور</a>&nbsp;: 1s<sup>2</sup> 2s<sup>2</sup> 2p<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">3</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {6, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">6 C <a href=\"#\" title=\"کربن\">کربن</a>&nbsp;: 1s<sup>2</sup> 2s<sup>2</sup> 2p<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">4</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {7, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">7 N <a href=\"#\" title=\"نیتروژن\">نیتروژن</a>&nbsp;: 1s<sup>2</sup> 2s<sup>2</sup> 2p<sup>3</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>3</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">5</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {8, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">8 O <a href=\"#\" title=\"اکسیژن\">اکسیژن</a>&nbsp;: 1s<sup>2</sup> 2s<sup>2</sup> 2p<sup>4</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>4</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">6</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {9, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">9 F <a href=\"#\" title=\"فلوئور\">فلوئور</a>&nbsp;: 1s<sup>2</sup> 2s<sup>2</sup> 2p<sup>5</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>5</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">7</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {10, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">10 Ne <a href=\"#\" title=\"نئون\">نئون</a>&nbsp;: 1s<sup>2</sup> 2s<sup>2</sup> 2p<sup>6</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {11, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">11 Na <a href=\"#\" title=\"سدیم\">سدیم</a>&nbsp;: [Ne] 3s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">1</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {12, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">12 Mg <a href=\"#\" class=\"mw-redirect\" title=\"منیزیوم\">منیزیوم</a>&nbsp;: [Ne] 3s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {13, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">13 Al <a href=\"#\" title=\"آلومینیوم\">آلومینیوم</a>&nbsp;: [Ne] 3s<sup>2</sup> 3p<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">3</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {14, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">14 Si <a href=\"#\" class=\"mw-redirect\" title=\"سیلیسیوم\">سیلیسیوم</a>&nbsp;: [Ne] 3s<sup>2</sup> 3p<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">4</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {15, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">15 P <a href=\"#\" title=\"فسفر\">فسفر</a>&nbsp;: [Ne] 3s<sup>2</sup> 3p<sup>3</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>3</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">5</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {16, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">16 S <a href=\"#\" title=\"گوگرد\">گوگرد</a>&nbsp;: [Ne] 3s<sup>2</sup> 3p<sup>4</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>4</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">6</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {17, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">17 Cl <a href=\"#\" title=\"کلر\">کلر</a>&nbsp;: [Ne] 3s<sup>2</sup> 3p<sup>5</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>5</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">7</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {18, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">18 Ar <a href=\"#\" title=\"آرگون\">آرگون</a>&nbsp;: [Ne] 3s<sup>2</sup> 3p<sup>6</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {19, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">19 K <a href=\"#\" title=\"پتاسیم\">پتاسیم</a>&nbsp;: [Ar] 4s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>4s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"4\">1</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {20, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">20 Ca <a href=\"#\" title=\"کلسیم\">کلسیم</a>&nbsp;: [Ar] 4s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {21, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">21 Sc <a href=\"#\" class=\"mw-redirect\" title=\"اسکاندیوم\">اسکاندیوم</a>&nbsp;: [Ar] 3d<sup>1</sup> 4s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>1</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">9</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {22, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">22 Ti <a href=\"#\" title=\"تیتانیوم\">تیتانیوم</a>&nbsp;: [Ar] 3d<sup>2</sup> 4s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>2</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">10</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {23, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">23 V <a href=\"#\" class=\"mw-redirect\" title=\"وانادیوم\">وانادیوم</a>&nbsp;: [Ar] 3d<sup>3</sup> 4s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>3</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">11</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {24, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">24 Cr <a href=\"#\" title=\"کروم\">کروم</a>&nbsp;: [Ar] 3d<sup>5</sup> 4s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>5</sup></td>\n" +
                "<td>4s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">13</td>\n" +
                "<td colspan=\"4\">1</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {25, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">25 Mn <a href=\"#\" title=\"منگنز\">منگنز</a>&nbsp;: [Ar] 3d<sup>5</sup> 4s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>5</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">13</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {26, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">26 Fe <a href=\"#\" title=\"آهن\">آهن</a>&nbsp;: [Ar] 3d<sup>6</sup> 4s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>6</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">14</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {27, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">27 Co <a href=\"#\" title=\"کبالت\">کبالت</a>&nbsp;: [Ar] 3d<sup>7</sup> 4s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>7</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">15</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {28, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">28 Ni <a href=\"#\" title=\"نیکل\">نیکل</a>&nbsp;: [Ar] 3d<sup>8</sup> 4s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>8</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">16</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {29, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">29 Cu <a href=\"#\" title=\"مس\">مس</a>&nbsp;: [Ar] 3d<sup>10</sup> 4s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">1</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {30, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">30 Zn <a href=\"#\" title=\"روی\">روی</a>&nbsp;: [Ar] 3d<sup>10</sup> 4s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {31, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">31 Ga <a href=\"#\" class=\"mw-redirect\" title=\"گالیوم\">گالیوم</a>&nbsp;: [Ar] 3d<sup>10</sup> 4s<sup>2</sup> 4p<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">3</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {32, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">32 Ge <a href=\"#\" class=\"mw-redirect\" title=\"ژرمانیوم\">ژرمانیوم</a>&nbsp;: [Ar] 3d<sup>10</sup> 4s<sup>2</sup> 4p<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">4</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {33, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">33 As <a href=\"#\" title=\"آرسنیک\">آرسنیک</a>&nbsp;: [Ar] 3d<sup>10</sup> 4s<sup>2</sup> 4p<sup>3</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>3</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">5</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {34, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">34 Se <a href=\"#\" title=\"سلنیوم\">سلنیوم</a>&nbsp;: [Ar] 3d<sup>10</sup> 4s<sup>2</sup> 4p<sup>4</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>4</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">6</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {35, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">35 Br <a href=\"#\" title=\"برم\">برم</a>&nbsp;: [Ar] 3d<sup>10</sup> 4s<sup>2</sup> 4p<sup>5</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>5</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">7</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {36, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">36 Kr <a href=\"#\" title=\"کریپتون\">کریپتون</a>&nbsp;: [Ar] 3d<sup>10</sup> 4s<sup>2</sup> 4p<sup>6</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {37, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">37 Rb <a href=\"#\" class=\"mw-redirect\" title=\"روبیدیوم\">روبیدیوم</a>&nbsp;: [Kr] 5s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"4\">1</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {38, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">38 Sr <a href=\"#\" title=\"استرانسیوم\">استرانسیوم</a>&nbsp;: [Kr] 5s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {39, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">39 Y <a href=\"#\" class=\"mw-redirect\" title=\"ایتریوم\">ایتریوم</a>&nbsp;: [Kr] 4d<sup>1</sup> 5s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">9</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {40, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">40 Zr <a href=\"#\" class=\"mw-redirect\" title=\"زیرکونیوم\">زیرکونیوم</a>&nbsp;: [Kr] 4d<sup>2</sup> 5s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">10</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {41, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">41 Nb <a href=\"#\" class=\"mw-redirect\" title=\"نیوبیوم\">نیوبیوم</a>&nbsp;: [Kr] 4d<sup>4</sup> 5s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>4</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">12</td>\n" +
                "<td colspan=\"4\">1</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {42, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">42 Mo <a href=\"#\" title=\"مولیبدن\">مولیبدن</a>&nbsp;: [Kr] 4d<sup>5</sup> 5s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>5</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">13</td>\n" +
                "<td colspan=\"4\">1</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {43, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">43 Tc <a href=\"#\" title=\"تکنسیوم\">تکنسیوم</a>&nbsp;: [Kr] 4d<sup>5</sup> 5s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>5</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">13</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {44, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">44 Ru <a href=\"#\" class=\"mw-redirect\" title=\"روتنیوم\">روتنیوم</a>&nbsp;: [Kr] 4d<sup>7</sup> 5s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>7</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">15</td>\n" +
                "<td colspan=\"4\">1</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {45, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">45 Rh <a href=\"#\" class=\"mw-redirect\" title=\"رودیوم\">رودیوم</a>&nbsp;: [Kr] 4d<sup>8</sup> 5s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>8</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">16</td>\n" +
                "<td colspan=\"4\">1</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {46, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">46 Pd <a href=\"#\" class=\"mw-redirect\" title=\"پالادیوم\">پالادیوم</a>&nbsp;: [Kr] 4d<sup>10</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">&nbsp;</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {47, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">47 Ag <a href=\"#\" title=\"نقره\">نقره</a>&nbsp;: [Kr] 4d<sup>10</sup> 5s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">1</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {48, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">48 Cd <a href=\"#\" class=\"mw-redirect\" title=\"کادمیوم\">کادمیوم</a>&nbsp;: [Kr] 4d<sup>10</sup> 5s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">2</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {49, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">49 In <a href=\"#\" title=\"ایندیوم\">ایندیوم</a>&nbsp;: [Kr] 4d<sup>10</sup> 5s<sup>2</sup> 5p<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">3</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {50, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">50 Sn <a href=\"#\" title=\"قلع\">قلع</a>&nbsp;: [Kr] 4d<sup>10</sup> 5s<sup>2</sup> 5p<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">4</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {51, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">51 Sb <a href=\"#\" title=\"آنتیموان\">آنتیموان</a>&nbsp;: [Kr] 4d<sup>10</sup> 5s<sup>2</sup> 5p<sup>3</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>3</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">5</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {52, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">52 Te <a href=\"#\" class=\"mw-redirect\" title=\"تلوریوم\">تلوریوم</a>&nbsp;: [Kr] 4d<sup>10</sup> 5s<sup>2</sup> 5p<sup>4</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>4</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">6</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {53, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">53 I <a href=\"#\" title=\"ید\">ید</a>&nbsp;: [Kr] 4d<sup>10</sup> 5s<sup>2</sup> 5p<sup>5</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>5</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">7</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {54, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">54 Xe <a href=\"#\" title=\"زنون\">زنون</a>&nbsp;: [Kr] 4d<sup>10</sup> 5s<sup>2</sup> 5p<sup>6</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">&nbsp;</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {55, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">55 Cs <a href=\"#\" class=\"mw-redirect\" title=\"سزیوم\">سزیوم</a>&nbsp;: [Xe] 6s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">1</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {56, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">56 Ba <a href=\"#\" class=\"mw-redirect\" title=\"باریوم\">باریوم</a>&nbsp;: [Xe] 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {57, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">57 La <a href=\"#\" class=\"mw-redirect\" title=\"لانتانیوم\">لانتانیوم</a>&nbsp;: [Xe] 5d<sup>1</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"4\">9</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {58, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">58 Ce <a href=\"#\" class=\"mw-redirect\" title=\"سریوم\">سریوم</a>&nbsp;: [Xe] 4f<sup>1</sup> 5d<sup>1</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>1</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">19</td>\n" +
                "<td colspan=\"4\">9</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {59, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">59 Pr <a href=\"#\" class=\"mw-redirect\" title=\"پرازئودیمیوم\">پرازئودیمیوم</a>&nbsp;: [Xe] 4f<sup>3</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>3</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">21</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {60, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">60 Nd <a href=\"#\" class=\"mw-redirect\" title=\"نئودیمیوم\">نئودیمیوم</a>&nbsp;: [Xe] 4f<sup>4</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>4</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">22</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {61, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">61 Pm <a href=\"#\" class=\"mw-redirect\" title=\"پرومتیوم\">پرومتیوم</a>&nbsp;: [Xe] 4f<sup>5</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>5</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">23</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {62, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">62 Sm <a href=\"#\" class=\"mw-redirect\" title=\"ساماریوم\">ساماریوم</a>&nbsp;: [Xe] 4f<sup>6</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>6</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">24</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {63, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">63 Eu <a href=\"#\" class=\"mw-redirect\" title=\"اروپیوم\">اروپیوم</a>&nbsp;: [Xe] 4f<sup>7</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>7</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">25</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {64, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">64 Gd <a href=\"#\" class=\"mw-redirect\" title=\"گادولینیوم\">گادولینیوم</a>&nbsp;: [Xe] 4f<sup>7</sup> 5d<sup>1</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>7</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">25</td>\n" +
                "<td colspan=\"4\">9</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {65, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">65 Tb <a href=\"#\" class=\"mw-redirect\" title=\"تربیوم\">تربیوم</a>&nbsp;: [Xe] 4f<sup>9</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>9</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">27</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {66, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">66 Dy <a href=\"#\" class=\"mw-redirect\" title=\"دیسپروزیوم\">دیسپروزیوم</a>&nbsp;: [Xe] 4f<sup>10</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>10</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">28</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {67, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">67 Ho <a href=\"#\" class=\"mw-redirect\" title=\"هولمیوم\">هولمیوم</a>&nbsp;: [Xe] 4f<sup>11</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>11</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">29</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {68, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">68 Er <a href=\"#\" title=\"اربیوم\">اربیوم</a>&nbsp;: [Xe] 4f<sup>12</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>12</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">30</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {69, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">69 Tm <a href=\"#\" title=\"تالیوم\">تالیوم</a>&nbsp;: [Xe] 4f<sup>13</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>13</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">31</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {70, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">70 Yb <a href=\"#\" class=\"mw-redirect\" title=\"ایتربیوم\">ایتربیوم</a>&nbsp;: [Xe] 4f<sup>14</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">8</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {71, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">71 Lu <a href=\"#\" class=\"mw-redirect\" title=\"لوتسیوم\">لوتسیوم</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>1</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">9</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {72, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">72 Hf <a href=\"#\" class=\"mw-redirect\" title=\"هافنیوم\">هافنیوم</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>2</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">10</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {73, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">73 Ta <a href=\"#\" class=\"mw-redirect\" title=\"تانتالیوم\">تانتالیوم</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>3</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>3</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">11</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {74, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">74 W <a href=\"#\" title=\"تنگستن\">تنگستن</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>4</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>4</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">12</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {75, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">75 Re <a href=\"#\" title=\"رنیوم\">رنیوم</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>5</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>5</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">13</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {76, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">76 Os <a href=\"#\" class=\"mw-redirect\" title=\"اوسمیوم\">اوسمیوم</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>6</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">14</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {77, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">77 Ir <a href=\"#\" class=\"mw-redirect\" title=\"ایریدیوم\">ایریدیوم</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>7</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>7</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">15</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {78, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">78 Pt <a href=\"#\" title=\"پلاتین\">پلاتین</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>9</sup> 6s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>9</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">17</td>\n" +
                "<td colspan=\"3\">1</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {79, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">79 Au <a href=\"#\" title=\"طلا\">طلا</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>10</sup> 6s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">1</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {80, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">80 Hg <a href=\"#\" title=\"جیوه\">جیوه</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>10</sup> 6s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">2</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {81, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">81 Tl <a href=\"#\" title=\"تالیوم\">تالیوم</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>10</sup> 6s<sup>2</sup> 6p<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>1</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">3</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {82, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">82 Pb <a href=\"#\" title=\"سرب\">سرب</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>10</sup> 6s<sup>2</sup> 6p<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>2</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">4</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {83, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">83 Bi <a href=\"#\" title=\"بیسموت\">بیسموت</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>10</sup> 6s<sup>2</sup> 6p<sup>3</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>3</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">5</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {84, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">84 Po <a href=\"#\" title=\"پولونیوم\">پولونیوم</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>10</sup> 6s<sup>2</sup> 6p<sup>4</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>4</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">6</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {85, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">85 At <a href=\"#\" title=\"استاتین\">استاتین</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>10</sup> 6s<sup>2</sup> 6p<sup>5</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>5</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">7</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {86, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">86 Rn <a href=\"#\" title=\"رادون\">رادون</a>&nbsp;: [Xe] 4f<sup>14</sup> 5d<sup>10</sup> 6s<sup>2</sup> 6p<sup>6</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">&nbsp;\n" +
                "</td></tr>"},
        {87, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">87 Fr <a href=\"#\" class=\"mw-redirect\" title=\"فرانسیوم\">فرانسیوم</a>&nbsp;: [Rn] 7s<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>1</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">1\n" +
                "</td></tr>"},
        {88, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">88 Ra <a href=\"#\" title=\"رادیوم\">رادیوم</a>&nbsp;: [Rn] 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {89, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">89 Ac <a href=\"#\" class=\"mw-redirect\" title=\"آکتینیوم\">آکتینیوم</a>&nbsp;: [Rn] 6d<sup>1</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>6d<sup>1</sup></td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">19</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {90, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">90 Th <a href=\"#\" title=\"توریوم\">توریوم</a>&nbsp;: [Rn] 6d<sup>2</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>6d<sup>2</sup></td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">18</td>\n" +
                "<td colspan=\"3\">10</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {91, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">91 Pa <a href=\"#\" class=\"mw-redirect\" title=\"پروتاکتینیوم\">پروتاکتینیوم</a>&nbsp;: [Rn] 5f<sup>2</sup> 6d<sup>1</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>2</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>6d<sup>1</sup></td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">20</td>\n" +
                "<td colspan=\"3\">9</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {92, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">92 U <a href=\"#\" title=\"اورانیوم\">اورانیوم</a>&nbsp;: [Rn] 5f<sup>3</sup> 6d<sup>1</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>3</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>6d<sup>1</sup></td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">21</td>\n" +
                "<td colspan=\"3\">9</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {93, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">93 Np <a href=\"#\" title=\"نپتونیوم\">نپتونیوم</a>&nbsp;: [Rn] 5f<sup>4</sup> 6d<sup>1</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>4</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>6d<sup>1</sup></td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">22</td>\n" +
                "<td colspan=\"3\">9</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {94, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">94 Pu <a href=\"#\" class=\"mw-redirect\" title=\"پلوتونیوم\">پلوتونیوم</a>&nbsp;: [Rn] 5f<sup>6</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>6</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">24</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {95, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">95 Am <a href=\"#\" class=\"mw-redirect\" title=\"آمرسیوم\">آمرسیوم</a>&nbsp;: [Rn] 5f<sup>7</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>7</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">25</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {96, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">96 Cm <a href=\"#\" class=\"mw-redirect\" title=\"کوریم\">کوریم</a>&nbsp;: [Rn] 5f<sup>7</sup> 6d<sup>1</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>7</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>6d<sup>1</sup></td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">25</td>\n" +
                "<td colspan=\"3\">9</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {97, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">97 Bk <a href=\"#\" class=\"mw-redirect\" title=\"برکلیوم\">برکلیوم</a>&nbsp;: [Rn] 5f<sup>9</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>9</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">27</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {98, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">98 Cf <a href=\"#\" title=\"کالیفرنیوم\">کالیفرنیوم</a>&nbsp;: [Rn] 5f<sup>10</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>10</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">28</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {99, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">99 Es <a href=\"#\" class=\"mw-redirect\" title=\"انیشتینیوم\">انیشتینیوم</a>&nbsp;: [Rn] 5f<sup>11</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>11</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">29</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {100, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">100 Fm <a href=\"#\" class=\"mw-redirect\" title=\"فرمیوم\">فرمیوم</a>&nbsp;: [Rn] 5f<sup>12</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>12</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">30</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {101, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">101 Md <a href=\"#\" class=\"mw-redirect\" title=\"مندلویوم\">مندلویوم</a>&nbsp;: [Rn] 5f<sup>13</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>13</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">31</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {102, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">102 No <a href=\"#\" class=\"mw-redirect\" title=\"نوبلیوم\">نوبلیوم</a>&nbsp;: [Rn] 5f<sup>14</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>14</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"},
        {103, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">103 Lr <a href=\"#\" class=\"mw-redirect\" title=\"لارنسیوم\">لارنسیوم</a>&nbsp;: probably [Rn] 5f<sup>14</sup> 7s<sup>2</sup> 7p<sup>1</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>14</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>&nbsp;</td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>7p<sup>1</sup>\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"3\">8</td>\n" +
                "<td colspan=\"2\">3\n" +
                "</td></tr>"},
        {104, "<tr align=\"center\">\n" +
                "<th colspan=\"19\">104 Rf <a href=\"#\" class=\"mw-redirect\" title=\"رادرفوردیوم\">رادرفوردیوم</a>&nbsp;: probably [Rn] 5f<sup>14</sup> 6d<sup>2</sup> 7s<sup>2</sup>\n" +
                "</th></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>1s<sup>2</sup></td>\n" +
                "<td>2s<sup>2</sup></td>\n" +
                "<td>2p<sup>6</sup></td>\n" +
                "<td>3s<sup>2</sup></td>\n" +
                "<td>3p<sup>6</sup></td>\n" +
                "<td>3d<sup>10</sup></td>\n" +
                "<td>4s<sup>2</sup></td>\n" +
                "<td>4p<sup>6</sup></td>\n" +
                "<td>4d<sup>10</sup></td>\n" +
                "<td>4f<sup>14</sup></td>\n" +
                "<td>5s<sup>2</sup></td>\n" +
                "<td>5p<sup>6</sup></td>\n" +
                "<td>5d<sup>10</sup></td>\n" +
                "<td>5f<sup>14</sup></td>\n" +
                "<td>6s<sup>2</sup></td>\n" +
                "<td>6p<sup>6</sup></td>\n" +
                "<td>6d<sup>2</sup></td>\n" +
                "<td>7s<sup>2</sup></td>\n" +
                "<td>&nbsp;\n" +
                "</td></tr>\n" +
                "<tr align=\"center\">\n" +
                "<td>2</td>\n" +
                "<td colspan=\"2\">8</td>\n" +
                "<td colspan=\"3\">18</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"4\">32</td>\n" +
                "<td colspan=\"3\">10</td>\n" +
                "<td colspan=\"2\">2\n" +
                "</td></tr>"}

        };
    }
}