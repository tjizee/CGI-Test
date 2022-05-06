using Microsoft.AspNetCore.Mvc.Formatters;

namespace CGI_HomeTest.SupportClass
{
    public class TextInputFormatter : InputFormatter
    {
        private const string ContentType = "text/plain";
        private const string Charset = "utf-8";

        public TextInputFormatter()
        {
            SupportedMediaTypes.Add(ContentType);
            SupportedMediaTypes.Add(Charset);
        }

        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            var request = context.HttpContext.Request;
            using (var reader = new StreamReader(request.Body))
            {
                var content = await reader.ReadToEndAsync();
                return await InputFormatterResult.SuccessAsync(content);
            }
        }

        public override bool CanRead(InputFormatterContext context)
        {
            var contentType = context.HttpContext.Request.ContentType;
            return contentType.StartsWith(ContentType);
        }
    }
}
