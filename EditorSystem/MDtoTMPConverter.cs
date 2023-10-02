/// preview側の空オブジェクトにアタッチするクラス
/// 文字列の変換のみを行うためMonoBehaviourは継承しない。


using Markdig;

public static class MDtoTMPConverter
{
    private static Markdig.MarkdownPipeline markdownPipeline = new MarkdownPipelineBuilder().UsePipeTables().Build();
    public static string Convert(string text)
    {
        text = Markdown.ToHtml(text);
        return text;
    }
}
