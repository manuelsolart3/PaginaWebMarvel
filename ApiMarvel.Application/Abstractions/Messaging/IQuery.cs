using ApiMarvel.Domain.Abstractions;
using MediatR;

namespace ApiMarvel.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}