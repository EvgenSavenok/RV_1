﻿namespace Application.Validation.CustomExceptions;

public class UnauthorizedException : Exception
{
    public UnauthorizedException(string message) : base(message) {}
}
