﻿using System.Threading;
using System.Threading.Tasks;

namespace Modix.Common.Messaging
{
    /// <summary>
    /// Describes an object that receives and handles application-wide requests from an <see cref="IMessagePublisher"/>.
    /// </summary>
    /// <typeparam name="TRequest">The type of request that this object handles.</typeparam>
    /// <typeparam name="TResponse">The type of response that is generated by handling the request.</typeparam>
    public interface IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        /// <summary>
        /// Handles a given request.
        /// </summary>
        /// <param name="request">The request data to be handled.</param>
        /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
        /// <returns>
        /// A <see cref="Task"/> that will complete when the operation has completed,
        /// containing the generated response data.
        /// </returns>
        Task<TResponse> HandleRequestAsync(TRequest request, CancellationToken cancellationToken = default);
    }
}
