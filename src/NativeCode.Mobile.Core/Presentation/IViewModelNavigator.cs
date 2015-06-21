﻿namespace NativeCode.Mobile.Core.Presentation
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Provides a contract to navigate via view models.
    /// </summary>
    public interface IViewModelNavigator
    {
        /// <summary>
        /// Pops the current view model.
        /// </summary>
        /// <typeparam name="TViewModel">The type of the view model.</typeparam>
        /// <param name="animated">if set to <c>true</c> animate transition.</param>
        /// <returns>Returns a view model.</returns>
        Task<TViewModel> PopAsync<TViewModel>(bool animated = true) where TViewModel : NavigableViewModel;

        /// <summary>
        /// Pops the current modal view model.
        /// </summary>
        /// <typeparam name="TViewModel">The type of the view model.</typeparam>
        /// <param name="animated">if set to <c>true</c> animate transition.</param>
        /// <returns>Returns a view model.</returns>
        Task<TViewModel> PopModalAsync<TViewModel>(bool animated = true) where TViewModel : NavigableViewModel;

        /// <summary>
        /// Pops to root view model.
        /// </summary>
        /// <param name="animated">if set to <c>true</c> animate transition.</param>
        /// <returns>Returns a <see cref="Task" />.</returns>
        Task PopToRootAsync(bool animated = true);

        /// <summary>
        /// Pushes the view model.
        /// </summary>
        /// <typeparam name="TViewModel">The type of the view model.</typeparam>
        /// <param name="animated">if set to <c>true</c> animate transition.</param>
        /// <returns>Returns a <see cref="Task" />.</returns>
        Task PushAsync<TViewModel>(bool animated = true) where TViewModel : NavigableViewModel;

        /// <summary>
        /// Pushes the view model.
        /// </summary>
        /// <typeparam name="TViewModel">The type of the view model.</typeparam>
        /// <param name="initializer">The initializer.</param>
        /// <param name="animated">if set to <c>true</c> animate transition.</param>
        /// <returns>Returns a <see cref="Task" />.</returns>
        Task PushAsync<TViewModel>(Action<TViewModel> initializer, bool animated = true) where TViewModel : NavigableViewModel;

        /// <summary>
        /// Pushes the view model as a model.
        /// </summary>
        /// <typeparam name="TViewModel">The type of the view model.</typeparam>
        /// <param name="animated">if set to <c>true</c> animate transition.</param>
        /// <returns>Returns a <see cref="Task" />.</returns>
        Task PushModalAsync<TViewModel>(bool animated = true) where TViewModel : NavigableViewModel;

        /// <summary>
        /// Pushes the view model as a model.
        /// </summary>
        /// <typeparam name="TViewModel">The type of the view model.</typeparam>
        /// <param name="initializer">The initializer.</param>
        /// <param name="animated">if set to <c>true</c> animate transition.</param>
        /// <returns>Returns a <see cref="Task" />.</returns>
        Task PushModalAsync<TViewModel>(Action<TViewModel> initializer, bool animated = true) where TViewModel : NavigableViewModel;
    }
}