﻿namespace Simple.Service.Monitoring.Library.Monitoring.Implementations.Publishers.Email.Templates
{
    public static class StandardEmailTemplate
    {
        public static string TemplateBody =>
            @"<!DOCTYPE html>
        <html lang=""en"" xmlns=""https://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office"">
        <head>
            <meta charset=""UTF-8"">
            <meta name=""viewport"" content=""width=device-width,initial-scale=1"">
            <meta name=""x-apple-disable-message-reformatting"">
            <title></title>
            <!--[if mso]>
            <noscript>
                <xml>
                    <o:OfficeDocumentSettings>
                        <o:PixelsPerInch>96</o:PixelsPerInch>
                    </o:OfficeDocumentSettings>
                </xml>
            </noscript>
            <![endif]-->
            <style>
                table, td, div, h1, p {font-family: Arial, sans-serif;}
                table, td {border:2px solid #000000 !important;}
            </style>
        </head>
        <body style=""margin:0;padding:0;"">
            <table role=""presentation"" style=""width:100%;border-collapse:collapse;border:0;border-spacing:0;background:#ffffff;"">
                <tr>
                    <td align=""center"" style=""padding:0;"">
                        #replace
                    </td>
                </tr>
            </table>
        </body>
        </html>";
    }
}
