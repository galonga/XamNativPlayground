using System;
using System.Threading.Tasks;

namespace ReBuyApp.Core.Common.Dialogs
{
    public interface IDialogService
    {
        Task ShowPopupAsync(string message);
        Task ShowSimpleDialogAsync(string message, string title);
        Task<bool> ShowBooleanDialogAsync(string message, string title);
        Task ShowMarkdownDialogAsync(string markdown, string title = null);
    }
}
