
using Microsoft.AspNetCore.Components;
using ZacharyKilburn_BlazorWASM.Data;
using ZacharyKilburn_BlazorWASM.Services;

namespace ZacharyKilburn_BlazorWASM.Shared
{
	public partial class NavMenu :ComponentBase
	{
		[Inject]
		private IMessageService MessageService { get; set; }
		[Inject]
		private ProjectLoader _projects { get; set; }
		[Inject]
		private BoardLoader _boards { get; set; }

		private bool collapseNavMenu = true;

		private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

		private void ToggleNavMenu()
		{
			collapseNavMenu = !collapseNavMenu;
		}
		bool projectCollapsibleCollapsed = true;
		bool boardCollapsibleCollapsed = true;



		public void Dispose()
		{
			// unsubscribe from OnMessage event
			MessageService.OnMessage -= MessageHandler;
		}

		private void MessageHandler(string message)
		{
			if (message == "boardsexpand")
			{
				boardCollapsibleCollapsed = false;
			}
			if (message == "boardscollapse")
			{
				boardCollapsibleCollapsed = true;
			}
			if (message == "projectsexpand")
			{
				projectCollapsibleCollapsed = false;
			}
			if (message == "projectscollapse")
			{
				projectCollapsibleCollapsed = true;
			}
			if (message == "projectsload")
			{
				if (!boardCollapsibleCollapsed)
				{
					boardCollapsibleCollapsed = true;
					StateHasChanged();
				}
			}
			if (message.Contains("boardsload"))
			{
				if (!projectCollapsibleCollapsed)
				{
					projectCollapsibleCollapsed = true;
					StateHasChanged();
				}
			}


		}
	}
}
