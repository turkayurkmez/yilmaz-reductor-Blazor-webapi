using Microsoft.AspNetCore.Components;
using SimpleTaskManager.Shared;
using System.Net.Http.Json;

namespace SimpleTaskManager.Client.Pages
{
    public partial class Index
    {
        [Inject]
        public HttpClient Http { get; set; }

        private IList<TaskItem> tasks;
        private string error;


        protected override async Task OnInitializedAsync()
        {
            try
            {
                tasks = await Http.GetFromJsonAsync<IList<TaskItem>>("api/taskItems");
            }
            catch (Exception)
            {
                error = "Bir hata meydana geldi";

            }
        }

        async Task CheckedChanged(TaskItem task)
        {
            task.IsComplete = !task.IsComplete;
            if (task.Id != 0)
            {
                string requestUri = $"/api/taskItems/{task.Id}";
                var response = await Http.PutAsJsonAsync(requestUri, task);
                if (!response.IsSuccessStatusCode)
                {
                    error = response.ReasonPhrase;
                }
            }


        }

        async Task DeleteTask(TaskItem taskItem)
        {
            tasks.Remove(taskItem);
            StateHasChanged();
            string requestUri = $"/api/taskItems/{taskItem.Id}";
            var response = await Http.DeleteAsync(requestUri);
            if (!response.IsSuccessStatusCode)
            {
                error = response.ReasonPhrase;
            }

        }
        private string taskName = "";
        private async Task AddTask()
        {
            if (!string.IsNullOrWhiteSpace(taskName))
            {
                TaskItem taskItem = new TaskItem { TaskName = taskName, IsComplete = false };
                //tasks.Add(taskItem);
                string requestUri = $"/api/taskItems";
                var response = await Http.PostAsJsonAsync(requestUri, taskItem);


                if (response.IsSuccessStatusCode)
                {
                    taskName = string.Empty;

                    var createdTask = await response.Content.ReadFromJsonAsync<TaskItem>();
                    tasks.Add(createdTask);

                }
                else
                {
                    error = response.ReasonPhrase;
                }

            }
        }
    }


}
