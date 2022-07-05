using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace myWebApp.Pages;

public class IndexModel : PageModel
    {
        public string StudentName { get; private set; } = "PageModel in C#";
        private readonly ILogger<IndexModel> _logger;
        private readonly myWebApp.Data.SchoolContext _context;

        public IndexModel(ILogger<IndexModel> logger, myWebApp.Data.SchoolContext context)
        {
            _logger = logger;
            _context= context;

           var p1= new  projectone.Class1();
           p1.Serilizestring("project1");
           var p2 = new projecttwo.Class1();
           p2.ProjectTwo();
        }

        public void OnGet()
        {
            var s =_context.Students?.Where(d=>d.ID==1).FirstOrDefault();
            this.StudentName = $"{s?.FirstMidName} {s?.LastName}";
        }
    }

