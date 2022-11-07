namespace BlazorApp.Todo
{
    public class TodoItem
    {
        //?를 사용하여 Title을 nullable 문자열로 선언합니다.
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
