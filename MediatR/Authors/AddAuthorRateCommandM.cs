﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRCQRS
{
    public record AddAuthorRateCommandM(int id, int rate) : IRequest<bool>;
}