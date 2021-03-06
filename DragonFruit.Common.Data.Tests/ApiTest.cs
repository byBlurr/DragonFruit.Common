﻿// DragonFruit.Common Copyright 2020 DragonFruit Network
// Licensed under the MIT License. Please refer to the LICENSE file at the root of this project for details

using System.Globalization;

namespace DragonFruit.Common.Data.Tests
{
    public abstract class ApiTest
    {
        protected static readonly ApiClient Client = new ApiClient(CultureInfo.InvariantCulture);
    }
}
