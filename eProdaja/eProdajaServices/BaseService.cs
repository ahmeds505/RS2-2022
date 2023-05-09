using AutoMapper;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseService<T, TDb, TSearch> : IService<T, TSearch> where T : class where TDb : class where TSearch : BaseSearchObject
    {
        public EProdajaContext Context { get; set; }
        public IMapper Mapper { get; set; }
        public BaseService(EProdajaContext context, IMapper mapper) 
        {
            Context = context;
            Mapper = mapper;
        }
        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var entity = Context.Set<TDb>().AsQueryable();

            entity = AddFilter(entity, search);

            if(search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                var pageSize = search.PageSize.Value;
                var page = search.Page.Value;
                //neki je problem ako je page>0
                entity = entity.Take(pageSize).Skip(pageSize * page);
            }

            var list = entity.ToList();

            //NOTE: elaborate IEnumerable vs IList
            return Mapper.Map<IList<T>>(list);
        }

        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query , TSearch search = null)
        {
            return query;
        }
        public T GetById(int id) 
        {
            var set = Context.Set<TDb>();

            var entity = set.Find(id);

            return Mapper.Map<T>(entity);
        }
    }
}
