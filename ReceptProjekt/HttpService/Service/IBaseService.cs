using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service
{
    public interface IBaseService<TEntity>
    {
        public Task<List<TEntity>> SelectAllAsync();
        public Task<ControllerResponse> UpdateAsync(TEntity entity);
        public Task<ControllerResponse> DeleteAsync(Guid id);
        public Task<ControllerResponse> InsertAsync(TEntity entity);
    }
}
