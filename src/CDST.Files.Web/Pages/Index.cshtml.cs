using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Threading.Tasks;

namespace CDST.Files.Web.Pages;

public class IndexModel : FilesPageModel
{
    public async void OnGet()
    {
        
    }

    public async Task<IActionResult> OnPostDownloadFileAsync()
    {
        var filePath = @"C:\Update\EVVP2024\专项排查标准模板240807.xlsx";
        var fileBytes = System.IO.File.ReadAllBytes(filePath);
        var file = new
        {
            Bytes = System.IO.File.ReadAllBytes(filePath),
            Name = "专项排查标准模板240807",
            Extension = "xlsx"
        };
        var stream = new MemoryStream(file.Bytes);
        FileStreamResult result = new FileStreamResult(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        result.FileDownloadName = string.Format("{0}.{1}", file.Name, file.Extension);
        return result;
    }
}
