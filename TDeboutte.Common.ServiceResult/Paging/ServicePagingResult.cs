using System.Collections.Generic;

namespace TDeboutte.Common.ServiceResult.Paging
{
    public class ServicePagingResult<T> : ServiceResult<IEnumerable<T>> where T : class
    {
        public PagingResult Paging { get; set; } = new();

        public ServicePagingResult() {}
        
        public ServicePagingResult(IEnumerable<T> data, PagingResult pagingResult)
        {
            Data = data;
            Paging = pagingResult;
        }

        public ServicePagingResult(IEnumerable<T> data, PagingRequest pagingRequest, int totalCount)
        {
            Data = data;
            Paging = new PagingResult(pagingRequest, totalCount);
        }

        public ServicePagingResult(ServiceResultType type, IEnumerable<T>? data = null, PagingResult? paging = null)
        {
            Type = type;
            Data = data;

            Paging = paging ?? new PagingResult();
        }
    }
}
