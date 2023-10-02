/// preview側の空オブジェクトにアタッチするクラス
/// 文字列の変換のみを行うためMonoBehaviourは継承しない。

using System.Collections;
using System.Collections.Generic;
using Markdig;

public class MDtoTMPConverter
{
    private Markdig.MarkdownPipeline markdownPipeline = new MarkdownPipelineBuilder().UsePipeTables().Build();
    public string Convert(string text)
    {
        text = Markdown.ToHtml(text);
        return text;
    }
}
