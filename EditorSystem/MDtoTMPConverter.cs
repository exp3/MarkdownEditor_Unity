/// preview���̋�I�u�W�F�N�g�ɃA�^�b�`����N���X
/// ������̕ϊ��݂̂��s������MonoBehaviour�͌p�����Ȃ��B


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
