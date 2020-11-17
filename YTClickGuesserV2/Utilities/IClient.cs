using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YTClickGuesserV2.Utilities
{
    public interface IClient
    {
        public Task<string> GetAsync(string search);
    }
}
