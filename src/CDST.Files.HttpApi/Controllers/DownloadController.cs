﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDST.Files.Controllers
{
    public class DownloadController: FilesController
    {
        /// <summary>
        /// 获取归档文件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/download")]
        [AllowAnonymous]
        public async Task<IActionResult> Download(Guid id)
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
            result.FileDownloadName = Uri.EscapeDataString(String.Format("{0}.{1}", file.Name, file.Extension));
            return result;
        }
    }
}
