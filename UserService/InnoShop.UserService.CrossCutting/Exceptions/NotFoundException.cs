﻿using InnoShop.UserService.CrossCutting.Models;

namespace InnoShop.UserService.CrossCutting.Exceptions;

[Serializable]
public sealed class NotFoundException : BaseException
{
    public NotFoundException(IReadOnlyCollection<ResponseError> errors)
        : base(errors, "Not Found. One or more validation errors occurred")
        => Errors = errors;
}