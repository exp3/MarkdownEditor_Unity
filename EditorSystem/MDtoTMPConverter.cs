/// preview���̋�I�u�W�F�N�g�ɃA�^�b�`����N���X
/// ������̕ϊ��݂̂��s������MonoBehaviour�͌p�����Ȃ��B

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
