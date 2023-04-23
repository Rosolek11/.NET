using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication2.Pages
{
    public class DeltaCalculatorModel : PageModel
    {
        [BindProperty]
        public int A { get; set; }

        [BindProperty]
        public int B { get; set; }

        [BindProperty]
        public int C { get; set; }

        public double? Delta { get; set; }
        public double? x1, x2;

        public void OnGet()
        {
           
        }

        public void OnPost()
        {

            Delta = B * B - 4 * A * C;
            if (Delta > 0)
            {
                x1 = (-B - Math.Sqrt((double)Delta)) / (2 * A);
                x2 = (-B + Math.Sqrt((double)Delta)) / (2 * A);
            }
            else if (Delta == 0)
            {
                x1 = -B / 2 * A;
            }
           
        }
    }
}
